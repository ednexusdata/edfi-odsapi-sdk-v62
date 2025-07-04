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
    /// TrackedChangesEdFiReportCardKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_reportCardKey")]
    public partial class TrackedChangesEdFiReportCardKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiReportCardKey" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization..</param>
        /// <param name="gradingPeriodDescriptor">The name of the period for which grades are reported..</param>
        /// <param name="gradingPeriodSequence">The sequential order of this period relative to other periods..</param>
        /// <param name="gradingPeriodSchoolId">The identifier assigned to a school..</param>
        /// <param name="gradingPeriodSchoolYear">The identifier for the grading period school year..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiReportCardKey(int educationOrganizationId = default, string gradingPeriodDescriptor = default, int gradingPeriodSequence = default, int gradingPeriodSchoolId = default, int gradingPeriodSchoolYear = default, string studentUniqueId = default)
        {
            this.EducationOrganizationId = educationOrganizationId;
            this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            this.GradingPeriodSequence = gradingPeriodSequence;
            this.GradingPeriodSchoolId = gradingPeriodSchoolId;
            this.GradingPeriodSchoolYear = gradingPeriodSchoolYear;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", EmitDefaultValue = false)]
        public int EducationOrganizationId { get; set; }

        /// <summary>
        /// The name of the period for which grades are reported.
        /// </summary>
        /// <value>The name of the period for which grades are reported.</value>
        [DataMember(Name = "gradingPeriodDescriptor", EmitDefaultValue = false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The sequential order of this period relative to other periods.
        /// </summary>
        /// <value>The sequential order of this period relative to other periods.</value>
        [DataMember(Name = "gradingPeriodSequence", EmitDefaultValue = false)]
        public int GradingPeriodSequence { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "gradingPeriodSchoolId", EmitDefaultValue = false)]
        public int GradingPeriodSchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name = "gradingPeriodSchoolYear", EmitDefaultValue = false)]
        public int GradingPeriodSchoolYear { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiReportCardKey {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodSequence: ").Append(GradingPeriodSequence).Append("\n");
            sb.Append("  GradingPeriodSchoolId: ").Append(GradingPeriodSchoolId).Append("\n");
            sb.Append("  GradingPeriodSchoolYear: ").Append(GradingPeriodSchoolYear).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
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
            // GradingPeriodDescriptor (string) maxLength
            if (this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
