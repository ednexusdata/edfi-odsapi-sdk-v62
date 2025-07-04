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
    /// EdFiCalendarDateCalendarEvent
    /// </summary>
    [DataContract(Name = "edFi_calendarDateCalendarEvent")]
    public partial class EdFiCalendarDateCalendarEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarDateCalendarEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCalendarDateCalendarEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarDateCalendarEvent" /> class.
        /// </summary>
        /// <param name="calendarEventDescriptor">The type of scheduled or unscheduled event for the day. (required).</param>
        /// <param name="ext">Extensions to the CalendarDateCalendarEvent entity..</param>
        public EdFiCalendarDateCalendarEvent(string calendarEventDescriptor = default, Object ext = default)
        {
            // to ensure "calendarEventDescriptor" is required (not null)
            if (calendarEventDescriptor == null)
            {
                throw new ArgumentNullException("calendarEventDescriptor is a required property for EdFiCalendarDateCalendarEvent and cannot be null");
            }
            this.CalendarEventDescriptor = calendarEventDescriptor;
            this.Ext = ext;
        }

        /// <summary>
        /// The type of scheduled or unscheduled event for the day.
        /// </summary>
        /// <value>The type of scheduled or unscheduled event for the day.</value>
        [DataMember(Name = "calendarEventDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string CalendarEventDescriptor { get; set; }

        /// <summary>
        /// Extensions to the CalendarDateCalendarEvent entity.
        /// </summary>
        /// <value>Extensions to the CalendarDateCalendarEvent entity.</value>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public Object Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiCalendarDateCalendarEvent {\n");
            sb.Append("  CalendarEventDescriptor: ").Append(CalendarEventDescriptor).Append("\n");
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
            // CalendarEventDescriptor (string) maxLength
            if (this.CalendarEventDescriptor != null && this.CalendarEventDescriptor.Length > 306)
            {
                yield return new ValidationResult("Invalid value for CalendarEventDescriptor, length must be less than 306.", new [] { "CalendarEventDescriptor" });
            }

            yield break;
        }
    }

}
