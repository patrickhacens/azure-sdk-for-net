﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.Shared;
using Azure.Core.TestFramework;
using Azure.Core.Tests;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Diagnostics;
using Azure.Messaging.EventHubs.Primitives;
using Azure.Messaging.EventHubs.Processor.Diagnostics;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Tests
{
#if NET5_0_OR_GREATER
    /// <summary>
    ///   The suite of tests for validating the diagnostics instrumentation
    ///   of the client library when ActivitySource is enabled.  These tests are not constrained to a specific
    ///   class or functional area.
    /// </summary>
    ///
    /// <remarks>
    ///   Every instrumented operation will trigger diagnostics activities as
    ///   long as they are being listened to, making it possible for other
    ///   tests to interfere with these. For this reason, these tests are
    ///   marked as non-parallelizable.
    /// </remarks>
    ///
    [NonParallelizable]
    [TestFixture]
    public class DiagnosticsActivitySourceTests
    {
        /// <summary>
        ///   Resets the activity source feature switch after each test.
        /// </summary>
        ///
        [SetUp]
        [TearDown]
        public void ResetFeatureSwitch()
        {
            ActivityExtensions.ResetFeatureSwitch();
        }

        /// <summary>
        ///   Verifies diagnostics functionality of the <see cref="EventProcessorClient.UpdateCheckpointAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public async Task UpdateCheckpointAsyncCreatesScope()
        {
            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(30));

            var completionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            var mockContext = new Mock<PartitionContext>("65");
            var mockLogger = new Mock<EventProcessorClientEventSource>();
            var mockProcessor = new Mock<EventProcessorClient>(Mock.Of<CheckpointStore>(), "cg", "host", "hub", 50, Mock.Of<TokenCredential>(), null) { CallBase = true };

            mockProcessor
                .Protected()
                .Setup<EventHubConnection>("CreateConnection")
                .Returns(Mock.Of<EventHubConnection>());

            mockLogger
                .Setup(log => log.UpdateCheckpointComplete(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Callback(() => completionSource.TrySetResult(true));

            mockProcessor.Object.Logger = mockLogger.Object;

            using var _ = SetAppConfigSwitch();

            using var listener = new TestActivitySourceListener(source => source.Name.StartsWith(DiagnosticProperty.DiagnosticNamespace));
            await InvokeUpdateCheckpointAsync(mockProcessor.Object, mockContext.Object.PartitionId, 65, 998, default);

            await Task.WhenAny(completionSource.Task, Task.Delay(Timeout.Infinite, cancellationSource.Token));
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The cancellation token should not have been signaled.");

            var checkpointActivity = listener.AssertAndRemoveActivity(DiagnosticProperty.EventProcessorCheckpointActivityName);
            CollectionAssert.Contains(checkpointActivity.Tags, new KeyValuePair<string, string>(MessagingClientDiagnostics.ServerAddress, "host"));
            CollectionAssert.Contains(checkpointActivity.Tags, new KeyValuePair<string, string>(MessagingClientDiagnostics.DestinationName, "hub"));
            CollectionAssert.Contains(checkpointActivity.Tags, new KeyValuePair<string, string>(MessagingClientDiagnostics.MessagingSystem, DiagnosticProperty.EventHubsServiceContext));
            cancellationSource.Cancel();
        }

        /// <summary>
        ///   Invokes the protected UpdateCheckpointAsync method on the processor client.
        /// </summary>
        ///
        /// <param name="target">The client whose method to invoke.</param>
        /// <param name="partitionId">The identifier of the partition the checkpoint is for.</param>
        /// <param name="offset">The offset to associate with the checkpoint, indicating that a processor should begin reading form the next event in the stream.</param>
        /// <param name="sequenceNumber">An optional sequence number to associate with the checkpoint, intended as informational metadata.  The <paramref name="offset" /> will be used for positioning when events are read.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> instance to signal a request to cancel the operation.</param>
        ///
        /// <returns>The translated options.</returns>
        ///
        private static Task InvokeUpdateCheckpointAsync(EventProcessorClient target,
                                                        string partitionId,
                                                        long offset,
                                                        long? sequenceNumber,
                                                        CancellationToken cancellationToken) =>
            (Task)
                typeof(EventProcessorClient)
                    .GetMethod("UpdateCheckpointAsync", BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(target, new object[] { partitionId, offset, sequenceNumber, cancellationToken });

        /// <summary>
        /// Sets and returns the app config switch to enable Activity Source. The switch must be disposed at the end of the test.
        /// </summary>
        private static TestAppContextSwitch SetAppConfigSwitch()
        {
            var s = new TestAppContextSwitch("Azure.Experimental.EnableActivitySource", "true");
            ActivityExtensions.ResetFeatureSwitch();
            return s;
        }
    }
#endif
}
