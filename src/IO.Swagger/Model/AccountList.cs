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
    /// List of accounts
    /// </summary>
    [DataContract]
    public partial class AccountList :  IEquatable<AccountList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountList" /> class.
        /// </summary>
        /// <param name="links">HATEOAS inspired links.</param>
        /// <param name="accounts">List of accounts.</param>
        public AccountList(List<Link> links = default(List<Link>), List<AccountInfo> accounts = default(List<AccountInfo>))
        {
            this.Links = links;
            this.Accounts = accounts;
        }
        
        /// <summary>
        /// HATEOAS inspired links
        /// </summary>
        /// <value>HATEOAS inspired links</value>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// List of accounts
        /// </summary>
        /// <value>List of accounts</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<AccountInfo> Accounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountList {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(input as AccountList);
        }

        /// <summary>
        /// Returns true if AccountList instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
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