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
    /// TrackedChangesEdFiStudentSectionAttendanceEventKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_studentSectionAttendanceEventKey")]
    public partial class TrackedChangesEdFiStudentSectionAttendanceEventKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStudentSectionAttendanceEventKey" /> class.
        /// </summary>
        /// <param name="attendanceEventCategoryDescriptor">A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy..</param>
        /// <param name="eventDate">Date for this attendance event..</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students..</param>
        /// <param name="schoolId">The identifier assigned to a school..</param>
        /// <param name="schoolYear">The identifier for the school year..</param>
        /// <param name="sectionIdentifier">The local identifier assigned to a section..</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session..</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student..</param>
        public TrackedChangesEdFiStudentSectionAttendanceEventKey(string attendanceEventCategoryDescriptor = default, DateOnly eventDate = default, string localCourseCode = default, int schoolId = default, int schoolYear = default, string sectionIdentifier = default, string sessionName = default, string studentUniqueId = default)
        {
            this.AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor;
            this.EventDate = eventDate;
            this.LocalCourseCode = localCourseCode;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
            this.SectionIdentifier = sectionIdentifier;
            this.SessionName = sessionName;
            this.StudentUniqueId = studentUniqueId;
        }

        /// <summary>
        /// A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.</value>
        [DataMember(Name = "attendanceEventCategoryDescriptor", EmitDefaultValue = false)]
        public string AttendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        /// <value>Date for this attendance event.</value>
        [DataMember(Name = "eventDate", EmitDefaultValue = false)]
        public DateOnly EventDate { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name = "localCourseCode", EmitDefaultValue = false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", EmitDefaultValue = false)]
        public int SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name = "sectionIdentifier", EmitDefaultValue = false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session.
        /// </summary>
        /// <value>The identifier for the calendar for the academic session.</value>
        [DataMember(Name = "sessionName", EmitDefaultValue = false)]
        public string SessionName { get; set; }

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
            sb.Append("class TrackedChangesEdFiStudentSectionAttendanceEventKey {\n");
            sb.Append("  AttendanceEventCategoryDescriptor: ").Append(AttendanceEventCategoryDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
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
            // AttendanceEventCategoryDescriptor (string) maxLength
            if (this.AttendanceEventCategoryDescriptor != null && this.AttendanceEventCategoryDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AttendanceEventCategoryDescriptor, length must be less than 306.", new [] { "AttendanceEventCategoryDescriptor" });
            }

            // LocalCourseCode (string) maxLength
            if (this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // SectionIdentifier (string) maxLength
            if (this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // SessionName (string) maxLength
            if (this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
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
