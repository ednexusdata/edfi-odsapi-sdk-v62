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
    /// EdFiStudentAcademicRecordDiploma
    /// </summary>
    [DataContract(Name = "edFi_studentAcademicRecordDiploma")]
    public partial class EdFiStudentAcademicRecordDiploma : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordDiploma" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAcademicRecordDiploma() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordDiploma" /> class.
        /// </summary>
        /// <param name="diplomaTypeDescriptor">The type of diploma/credential that is awarded to a student in recognition of his/her completion of the curricular requirements. (required).</param>
        /// <param name="diplomaAwardDate">The month, day, and year on which the student met  graduation requirements and was awarded a diploma. (required).</param>
        /// <param name="achievementCategoryDescriptor">The category of achievement attributed to the individual..</param>
        /// <param name="diplomaLevelDescriptor">The level of diploma/credential that is awarded to a student in recognition of completion of the curricular requirements..</param>
        /// <param name="achievementCategorySystem">The system that defines the categories by which an achievement is attributed to the individual..</param>
        /// <param name="achievementTitle">The title assigned to the achievement..</param>
        /// <param name="criteria">The criteria for competency-based completion of the achievement/award..</param>
        /// <param name="criteriaURL">The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award..</param>
        /// <param name="cteCompleter">Indicated a student who reached a state-defined threshold of vocational education and who attained a high school diploma or its recognized state equivalent or GED..</param>
        /// <param name="diplomaAwardExpiresDate">Date on which the diploma expires..</param>
        /// <param name="diplomaDescription">The description of the diploma given to the student for accomplishments..</param>
        /// <param name="evidenceStatement">A statement or reference describing the evidence that the individual met the criteria for attainment of the achievement/award..</param>
        /// <param name="imageURL">The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the achievement/award..</param>
        /// <param name="issuerName">The name of the agent, entity, or institution issuing the element..</param>
        /// <param name="issuerOriginURL">The Uniform Resource Locator (URL) from which the award was issued..</param>
        /// <param name="ext">Extensions to the StudentAcademicRecordDiploma entity..</param>
        public EdFiStudentAcademicRecordDiploma(string diplomaTypeDescriptor = default, DateOnly diplomaAwardDate = default, string achievementCategoryDescriptor = default, string diplomaLevelDescriptor = default, string achievementCategorySystem = default, string achievementTitle = default, string criteria = default, string criteriaURL = default, bool? cteCompleter = default, DateOnly? diplomaAwardExpiresDate = default, string diplomaDescription = default, string evidenceStatement = default, string imageURL = default, string issuerName = default, string issuerOriginURL = default, Object ext = default)
        {
            // to ensure "diplomaTypeDescriptor" is required (not null)
            if (diplomaTypeDescriptor == null)
            {
                throw new ArgumentNullException("diplomaTypeDescriptor is a required property for EdFiStudentAcademicRecordDiploma and cannot be null");
            }
            this.DiplomaTypeDescriptor = diplomaTypeDescriptor;
            this.DiplomaAwardDate = diplomaAwardDate;
            this.AchievementCategoryDescriptor = achievementCategoryDescriptor;
            this.DiplomaLevelDescriptor = diplomaLevelDescriptor;
            this.AchievementCategorySystem = achievementCategorySystem;
            this.AchievementTitle = achievementTitle;
            this.Criteria = criteria;
            this.CriteriaURL = criteriaURL;
            this.CteCompleter = cteCompleter;
            this.DiplomaAwardExpiresDate = diplomaAwardExpiresDate;
            this.DiplomaDescription = diplomaDescription;
            this.EvidenceStatement = evidenceStatement;
            this.ImageURL = imageURL;
            this.IssuerName = issuerName;
            this.IssuerOriginURL = issuerOriginURL;
            this.Ext = ext;
        }

        /// <summary>
        /// The type of diploma/credential that is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        /// <value>The type of diploma/credential that is awarded to a student in recognition of his/her completion of the curricular requirements.</value>
        [DataMember(Name = "diplomaTypeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string DiplomaTypeDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year on which the student met  graduation requirements and was awarded a diploma.
        /// </summary>
        /// <value>The month, day, and year on which the student met  graduation requirements and was awarded a diploma.</value>
        [DataMember(Name = "diplomaAwardDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly DiplomaAwardDate { get; set; }

        /// <summary>
        /// The category of achievement attributed to the individual.
        /// </summary>
        /// <value>The category of achievement attributed to the individual.</value>
        [DataMember(Name = "achievementCategoryDescriptor", EmitDefaultValue = true)]
        public string AchievementCategoryDescriptor { get; set; }

        /// <summary>
        /// The level of diploma/credential that is awarded to a student in recognition of completion of the curricular requirements.
        /// </summary>
        /// <value>The level of diploma/credential that is awarded to a student in recognition of completion of the curricular requirements.</value>
        [DataMember(Name = "diplomaLevelDescriptor", EmitDefaultValue = true)]
        public string DiplomaLevelDescriptor { get; set; }

        /// <summary>
        /// The system that defines the categories by which an achievement is attributed to the individual.
        /// </summary>
        /// <value>The system that defines the categories by which an achievement is attributed to the individual.</value>
        [DataMember(Name = "achievementCategorySystem", EmitDefaultValue = true)]
        public string AchievementCategorySystem { get; set; }

        /// <summary>
        /// The title assigned to the achievement.
        /// </summary>
        /// <value>The title assigned to the achievement.</value>
        [DataMember(Name = "achievementTitle", EmitDefaultValue = true)]
        public string AchievementTitle { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the achievement/award.
        /// </summary>
        /// <value>The criteria for competency-based completion of the achievement/award.</value>
        [DataMember(Name = "criteria", EmitDefaultValue = true)]
        public string Criteria { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award.
        /// </summary>
        /// <value>The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award.</value>
        [DataMember(Name = "criteriaURL", EmitDefaultValue = true)]
        public string CriteriaURL { get; set; }

        /// <summary>
        /// Indicated a student who reached a state-defined threshold of vocational education and who attained a high school diploma or its recognized state equivalent or GED.
        /// </summary>
        /// <value>Indicated a student who reached a state-defined threshold of vocational education and who attained a high school diploma or its recognized state equivalent or GED.</value>
        [DataMember(Name = "cteCompleter", EmitDefaultValue = true)]
        public bool? CteCompleter { get; set; }

        /// <summary>
        /// Date on which the diploma expires.
        /// </summary>
        /// <value>Date on which the diploma expires.</value>
        [DataMember(Name = "diplomaAwardExpiresDate", EmitDefaultValue = true)]
        public DateOnly? DiplomaAwardExpiresDate { get; set; }

        /// <summary>
        /// The description of the diploma given to the student for accomplishments.
        /// </summary>
        /// <value>The description of the diploma given to the student for accomplishments.</value>
        [DataMember(Name = "diplomaDescription", EmitDefaultValue = true)]
        public string DiplomaDescription { get; set; }

        /// <summary>
        /// A statement or reference describing the evidence that the individual met the criteria for attainment of the achievement/award.
        /// </summary>
        /// <value>A statement or reference describing the evidence that the individual met the criteria for attainment of the achievement/award.</value>
        [DataMember(Name = "evidenceStatement", EmitDefaultValue = true)]
        public string EvidenceStatement { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the achievement/award.
        /// </summary>
        /// <value>The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the achievement/award.</value>
        [DataMember(Name = "imageURL", EmitDefaultValue = true)]
        public string ImageURL { get; set; }

        /// <summary>
        /// The name of the agent, entity, or institution issuing the element.
        /// </summary>
        /// <value>The name of the agent, entity, or institution issuing the element.</value>
        [DataMember(Name = "issuerName", EmitDefaultValue = true)]
        public string IssuerName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the award was issued.
        /// </summary>
        /// <value>The Uniform Resource Locator (URL) from which the award was issued.</value>
        [DataMember(Name = "issuerOriginURL", EmitDefaultValue = true)]
        public string IssuerOriginURL { get; set; }

        /// <summary>
        /// Extensions to the StudentAcademicRecordDiploma entity.
        /// </summary>
        /// <value>Extensions to the StudentAcademicRecordDiploma entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentAcademicRecordDiploma {\n");
            sb.Append("  DiplomaTypeDescriptor: ").Append(DiplomaTypeDescriptor).Append("\n");
            sb.Append("  DiplomaAwardDate: ").Append(DiplomaAwardDate).Append("\n");
            sb.Append("  AchievementCategoryDescriptor: ").Append(AchievementCategoryDescriptor).Append("\n");
            sb.Append("  DiplomaLevelDescriptor: ").Append(DiplomaLevelDescriptor).Append("\n");
            sb.Append("  AchievementCategorySystem: ").Append(AchievementCategorySystem).Append("\n");
            sb.Append("  AchievementTitle: ").Append(AchievementTitle).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  CriteriaURL: ").Append(CriteriaURL).Append("\n");
            sb.Append("  CteCompleter: ").Append(CteCompleter).Append("\n");
            sb.Append("  DiplomaAwardExpiresDate: ").Append(DiplomaAwardExpiresDate).Append("\n");
            sb.Append("  DiplomaDescription: ").Append(DiplomaDescription).Append("\n");
            sb.Append("  EvidenceStatement: ").Append(EvidenceStatement).Append("\n");
            sb.Append("  ImageURL: ").Append(ImageURL).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  IssuerOriginURL: ").Append(IssuerOriginURL).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            // DiplomaTypeDescriptor (string) maxLength
            if (this.DiplomaTypeDescriptor != null && this.DiplomaTypeDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DiplomaTypeDescriptor, length must be less than 306.", new [] { "DiplomaTypeDescriptor" });
            }

            // AchievementCategoryDescriptor (string) maxLength
            if (this.AchievementCategoryDescriptor != null && this.AchievementCategoryDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for AchievementCategoryDescriptor, length must be less than 306.", new [] { "AchievementCategoryDescriptor" });
            }

            // DiplomaLevelDescriptor (string) maxLength
            if (this.DiplomaLevelDescriptor != null && this.DiplomaLevelDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for DiplomaLevelDescriptor, length must be less than 306.", new [] { "DiplomaLevelDescriptor" });
            }

            // AchievementCategorySystem (string) maxLength
            if (this.AchievementCategorySystem != null && this.AchievementCategorySystem.Length > 60)
            {
                yield return new ValidationResult("Invalid value for AchievementCategorySystem, length must be less than 60.", new [] { "AchievementCategorySystem" });
            }

            // AchievementTitle (string) maxLength
            if (this.AchievementTitle != null && this.AchievementTitle.Length > 60)
            {
                yield return new ValidationResult("Invalid value for AchievementTitle, length must be less than 60.", new [] { "AchievementTitle" });
            }

            // Criteria (string) maxLength
            if (this.Criteria != null && this.Criteria.Length > 150)
            {
                yield return new ValidationResult("Invalid value for Criteria, length must be less than 150.", new [] { "Criteria" });
            }

            // CriteriaURL (string) maxLength
            if (this.CriteriaURL != null && this.CriteriaURL.Length > 255)
            {
                yield return new ValidationResult("Invalid value for CriteriaURL, length must be less than 255.", new [] { "CriteriaURL" });
            }

            // DiplomaDescription (string) maxLength
            if (this.DiplomaDescription != null && this.DiplomaDescription.Length > 80)
            {
                yield return new ValidationResult("Invalid value for DiplomaDescription, length must be less than 80.", new [] { "DiplomaDescription" });
            }

            // EvidenceStatement (string) maxLength
            if (this.EvidenceStatement != null && this.EvidenceStatement.Length > 150)
            {
                yield return new ValidationResult("Invalid value for EvidenceStatement, length must be less than 150.", new [] { "EvidenceStatement" });
            }

            // ImageURL (string) maxLength
            if (this.ImageURL != null && this.ImageURL.Length > 255)
            {
                yield return new ValidationResult("Invalid value for ImageURL, length must be less than 255.", new [] { "ImageURL" });
            }

            // IssuerName (string) maxLength
            if (this.IssuerName != null && this.IssuerName.Length > 150)
            {
                yield return new ValidationResult("Invalid value for IssuerName, length must be less than 150.", new [] { "IssuerName" });
            }

            // IssuerOriginURL (string) maxLength
            if (this.IssuerOriginURL != null && this.IssuerOriginURL.Length > 255)
            {
                yield return new ValidationResult("Invalid value for IssuerOriginURL, length must be less than 255.", new [] { "IssuerOriginURL" });
            }

            yield break;
        }
    }

}
