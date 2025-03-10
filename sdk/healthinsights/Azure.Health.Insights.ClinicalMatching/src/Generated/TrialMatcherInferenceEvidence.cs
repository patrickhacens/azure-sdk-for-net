// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A piece of evidence corresponding to a Trial Matcher inference. </summary>
    public partial class TrialMatcherInferenceEvidence
    {
        /// <summary> Initializes a new instance of TrialMatcherInferenceEvidence. </summary>
        internal TrialMatcherInferenceEvidence()
        {
        }

        /// <summary> Initializes a new instance of TrialMatcherInferenceEvidence. </summary>
        /// <param name="eligibilityCriteriaEvidence"> A piece of evidence from the eligibility criteria text of a clinical trial. </param>
        /// <param name="patientDataEvidence"> A piece of evidence from a clinical note (text document). </param>
        /// <param name="patientInfoEvidence">
        /// A piece of clinical information, expressed as a code in a clinical coding
        /// system.
        /// </param>
        /// <param name="importance"> A value indicating how important this piece of evidence is for the inference. </param>
        internal TrialMatcherInferenceEvidence(string eligibilityCriteriaEvidence, ClinicalNoteEvidence patientDataEvidence, ClinicalCodedElement patientInfoEvidence, float? importance)
        {
            EligibilityCriteriaEvidence = eligibilityCriteriaEvidence;
            PatientDataEvidence = patientDataEvidence;
            PatientInfoEvidence = patientInfoEvidence;
            Importance = importance;
        }

        /// <summary> A piece of evidence from the eligibility criteria text of a clinical trial. </summary>
        public string EligibilityCriteriaEvidence { get; }
        /// <summary> A piece of evidence from a clinical note (text document). </summary>
        public ClinicalNoteEvidence PatientDataEvidence { get; }
        /// <summary>
        /// A piece of clinical information, expressed as a code in a clinical coding
        /// system.
        /// </summary>
        public ClinicalCodedElement PatientInfoEvidence { get; }
        /// <summary> A value indicating how important this piece of evidence is for the inference. </summary>
        public float? Importance { get; }
    }
}
