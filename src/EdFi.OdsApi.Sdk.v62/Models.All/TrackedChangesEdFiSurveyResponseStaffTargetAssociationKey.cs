/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.v62.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.v62.Models.All
{
    /// <summary>
    /// TrackedChangesEdFiSurveyResponseStaffTargetAssociationKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_surveyResponseStaffTargetAssociationKey")]
    public partial class TrackedChangesEdFiSurveyResponseStaffTargetAssociationKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiSurveyResponseStaffTargetAssociationKey" /> class.
        /// </summary>
        /// <param name="staffUniqueId">A unique alphanumeric code assigned to a staff..</param>
        /// <param name="varNamespace">Namespace for the survey..</param>
        /// <param name="surveyIdentifier">The unique survey identifier from the survey tool..</param>
        /// <param name="surveyResponseIdentifier">The identifier of the survey typically from the survey application..</param>
        public TrackedChangesEdFiSurveyResponseStaffTargetAssociationKey(string staffUniqueId = default, string varNamespace = default, string surveyIdentifier = default, string surveyResponseIdentifier = default)
        {
            this.StaffUniqueId = staffUniqueId;
            this.Namespace = varNamespace;
            this.SurveyIdentifier = surveyIdentifier;
            this.SurveyResponseIdentifier = surveyResponseIdentifier;
        }

        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a staff.</value>
        [DataMember(Name = "staffUniqueId", EmitDefaultValue = false)]
        public string StaffUniqueId { get; set; }

        /// <summary>
        /// Namespace for the survey.
        /// </summary>
        /// <value>Namespace for the survey.</value>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The unique survey identifier from the survey tool.
        /// </summary>
        /// <value>The unique survey identifier from the survey tool.</value>
        [DataMember(Name = "surveyIdentifier", EmitDefaultValue = false)]
        public string SurveyIdentifier { get; set; }

        /// <summary>
        /// The identifier of the survey typically from the survey application.
        /// </summary>
        /// <value>The identifier of the survey typically from the survey application.</value>
        [DataMember(Name = "surveyResponseIdentifier", EmitDefaultValue = false)]
        public string SurveyResponseIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiSurveyResponseStaffTargetAssociationKey {\n");
            sb.Append("  StaffUniqueId: ").Append(StaffUniqueId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SurveyIdentifier: ").Append(SurveyIdentifier).Append("\n");
            sb.Append("  SurveyResponseIdentifier: ").Append(SurveyResponseIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // StaffUniqueId (string) maxLength
            if (this.StaffUniqueId != null && this.StaffUniqueId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for StaffUniqueId, length must be less than 32.", new [] { "StaffUniqueId" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // SurveyIdentifier (string) maxLength
            if (this.SurveyIdentifier != null && this.SurveyIdentifier.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SurveyIdentifier, length must be less than 60.", new [] { "SurveyIdentifier" });
            }

            // SurveyResponseIdentifier (string) maxLength
            if (this.SurveyResponseIdentifier != null && this.SurveyResponseIdentifier.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SurveyResponseIdentifier, length must be less than 60.", new [] { "SurveyResponseIdentifier" });
            }

            yield break;
        }
    }

}
