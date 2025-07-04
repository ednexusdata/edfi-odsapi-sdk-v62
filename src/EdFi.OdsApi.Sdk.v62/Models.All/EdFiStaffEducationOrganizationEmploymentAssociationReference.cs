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
    /// EdFiStaffEducationOrganizationEmploymentAssociationReference
    /// </summary>
    [DataContract(Name = "edFi_staffEducationOrganizationEmploymentAssociationReference")]
    public partial class EdFiStaffEducationOrganizationEmploymentAssociationReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffEducationOrganizationEmploymentAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffEducationOrganizationEmploymentAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffEducationOrganizationEmploymentAssociationReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="employmentStatusDescriptor">Reflects the type of employment or contract. (required).</param>
        /// <param name="hireDate">The month, day, and year on which an individual was hired for a position. (required).</param>
        /// <param name="staffUniqueId">A unique alphanumeric code assigned to a staff. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStaffEducationOrganizationEmploymentAssociationReference(int educationOrganizationId = default, string employmentStatusDescriptor = default, DateOnly hireDate = default, string staffUniqueId = default, Link link = default)
        {
            this.EducationOrganizationId = educationOrganizationId;
            // to ensure "employmentStatusDescriptor" is required (not null)
            if (employmentStatusDescriptor == null)
            {
                throw new ArgumentNullException("employmentStatusDescriptor is a required property for EdFiStaffEducationOrganizationEmploymentAssociationReference and cannot be null");
            }
            this.EmploymentStatusDescriptor = employmentStatusDescriptor;
            this.HireDate = hireDate;
            // to ensure "staffUniqueId" is required (not null)
            if (staffUniqueId == null)
            {
                throw new ArgumentNullException("staffUniqueId is a required property for EdFiStaffEducationOrganizationEmploymentAssociationReference and cannot be null");
            }
            this.StaffUniqueId = staffUniqueId;
            this.Link = link;
        }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public int EducationOrganizationId { get; set; }

        /// <summary>
        /// Reflects the type of employment or contract.
        /// </summary>
        /// <value>Reflects the type of employment or contract.</value>
        [DataMember(Name = "employmentStatusDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string EmploymentStatusDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was hired for a position.
        /// </summary>
        /// <value>The month, day, and year on which an individual was hired for a position.</value>
        [DataMember(Name = "hireDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly HireDate { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a staff.</value>
        [DataMember(Name = "staffUniqueId", IsRequired = true, EmitDefaultValue = true)]
        public string StaffUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStaffEducationOrganizationEmploymentAssociationReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  EmploymentStatusDescriptor: ").Append(EmploymentStatusDescriptor).Append("\n");
            sb.Append("  HireDate: ").Append(HireDate).Append("\n");
            sb.Append("  StaffUniqueId: ").Append(StaffUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            // EmploymentStatusDescriptor (string) maxLength
            if (this.EmploymentStatusDescriptor != null && this.EmploymentStatusDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for EmploymentStatusDescriptor, length must be less than 306.", new [] { "EmploymentStatusDescriptor" });
            }

            // StaffUniqueId (string) maxLength
            if (this.StaffUniqueId != null && this.StaffUniqueId.Length > 32)
            {
                yield return new ValidationResult("Invalid value for StaffUniqueId, length must be less than 32.", new [] { "StaffUniqueId" });
            }

            yield break;
        }
    }

}
