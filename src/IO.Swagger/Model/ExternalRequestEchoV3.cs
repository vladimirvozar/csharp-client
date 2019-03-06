/* 
 * Nordea Account Information Services API v3
 *
 * Open Banking API
 *
 * OpenAPI spec version: 2.2.0-SNAPSHOT
 * Contact: support@nordeaopenbanking.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ExternalRequestEchoV3
    /// </summary>
    [DataContract]
    public partial class ExternalRequestEchoV3 :  IEquatable<ExternalRequestEchoV3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalRequestEchoV3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalRequestEchoV3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalRequestEchoV3" /> class.
        /// </summary>
        /// <param name="messageIdentifier">Original request id for correlation purposes (required).</param>
        /// <param name="url">Original request url.</param>
        public ExternalRequestEchoV3(string messageIdentifier = default(string), string url = default(string))
        {
            // to ensure "messageIdentifier" is required (not null)
            if (messageIdentifier == null)
            {
                throw new InvalidDataException("messageIdentifier is a required property for ExternalRequestEchoV3 and cannot be null");
            }
            else
            {
                this.MessageIdentifier = messageIdentifier;
            }
            this.Url = url;
        }
        
        /// <summary>
        /// Original request id for correlation purposes
        /// </summary>
        /// <value>Original request id for correlation purposes</value>
        [DataMember(Name="message_identifier", EmitDefaultValue=false)]
        public string MessageIdentifier { get; set; }

        /// <summary>
        /// Original request url
        /// </summary>
        /// <value>Original request url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalRequestEchoV3 {\n");
            sb.Append("  MessageIdentifier: ").Append(MessageIdentifier).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalRequestEchoV3);
        }

        /// <summary>
        /// Returns true if ExternalRequestEchoV3 instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalRequestEchoV3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalRequestEchoV3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageIdentifier == input.MessageIdentifier ||
                    (this.MessageIdentifier != null &&
                    this.MessageIdentifier.Equals(input.MessageIdentifier))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MessageIdentifier != null)
                    hashCode = hashCode * 59 + this.MessageIdentifier.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
