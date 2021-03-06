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
    /// Details of paginated response
    /// </summary>
    [DataContract]
    public partial class PaginationV2 :  IEquatable<PaginationV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationV2" /> class.
        /// </summary>
        /// <param name="continuationKey">Resource listing may return a continuationKey if there&#39;s more results available. Request may be retried with the continuationKey, but otherwise same parameters, in order to get more results..</param>
        public PaginationV2(string continuationKey = default(string))
        {
            this.ContinuationKey = continuationKey;
        }
        
        /// <summary>
        /// Resource listing may return a continuationKey if there&#39;s more results available. Request may be retried with the continuationKey, but otherwise same parameters, in order to get more results.
        /// </summary>
        /// <value>Resource listing may return a continuationKey if there&#39;s more results available. Request may be retried with the continuationKey, but otherwise same parameters, in order to get more results.</value>
        [DataMember(Name="continuationKey", EmitDefaultValue=false)]
        public string ContinuationKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginationV2 {\n");
            sb.Append("  ContinuationKey: ").Append(ContinuationKey).Append("\n");
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
            return this.Equals(input as PaginationV2);
        }

        /// <summary>
        /// Returns true if PaginationV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContinuationKey == input.ContinuationKey ||
                    (this.ContinuationKey != null &&
                    this.ContinuationKey.Equals(input.ContinuationKey))
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
                if (this.ContinuationKey != null)
                    hashCode = hashCode * 59 + this.ContinuationKey.GetHashCode();
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
