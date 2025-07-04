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
    /// EdFiLocalEncumbrance
    /// </summary>
    [DataContract(Name = "edFi_localEncumbrance")]
    public partial class EdFiLocalEncumbrance : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEncumbrance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocalEncumbrance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEncumbrance" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="asOfDate">The date of the reported amount for the account. (required).</param>
        /// <param name="localAccountReference">localAccountReference (required).</param>
        /// <param name="amount">Current balance for the account. (required).</param>
        /// <param name="financialCollectionDescriptor">The accounting period or grouping for which the amount is collected..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">Extensions to the LocalEncumbrance entity..</param>
        public EdFiLocalEncumbrance(string id = default, DateOnly asOfDate = default, EdFiLocalAccountReference localAccountReference = default, double amount = default, string financialCollectionDescriptor = default, string etag = default, Object ext = default)
        {
            this.AsOfDate = asOfDate;
            // to ensure "localAccountReference" is required (not null)
            if (localAccountReference == null)
            {
                throw new ArgumentNullException("localAccountReference is a required property for EdFiLocalEncumbrance and cannot be null");
            }
            this.LocalAccountReference = localAccountReference;
            this.Amount = amount;
            this.Id = id;
            this.FinancialCollectionDescriptor = financialCollectionDescriptor;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The date of the reported amount for the account.
        /// </summary>
        /// <value>The date of the reported amount for the account.</value>
        [DataMember(Name = "asOfDate", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly AsOfDate { get; set; }

        /// <summary>
        /// Gets or Sets LocalAccountReference
        /// </summary>
        [DataMember(Name = "localAccountReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiLocalAccountReference LocalAccountReference { get; set; }

        /// <summary>
        /// Current balance for the account.
        /// </summary>
        /// <value>Current balance for the account.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public double Amount { get; set; }

        /// <summary>
        /// The accounting period or grouping for which the amount is collected.
        /// </summary>
        /// <value>The accounting period or grouping for which the amount is collected.</value>
        [DataMember(Name = "financialCollectionDescriptor", EmitDefaultValue = true)]
        public string FinancialCollectionDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Extensions to the LocalEncumbrance entity.
        /// </summary>
        /// <value>Extensions to the LocalEncumbrance entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiLocalEncumbrance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  LocalAccountReference: ").Append(LocalAccountReference).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FinancialCollectionDescriptor: ").Append(FinancialCollectionDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            // FinancialCollectionDescriptor (string) maxLength
            if (this.FinancialCollectionDescriptor != null && this.FinancialCollectionDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for FinancialCollectionDescriptor, length must be less than 306.", new [] { "FinancialCollectionDescriptor" });
            }

            yield break;
        }
    }

}
