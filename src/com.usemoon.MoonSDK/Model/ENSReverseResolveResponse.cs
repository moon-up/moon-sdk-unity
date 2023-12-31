/*
 * moon-vault-api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = com.usemoon.MoonSDK.Client.OpenAPIDateConverter;

namespace com.usemoon.MoonSDK.Model
{
    /// <summary>
    /// ENSReverseResolveResponse
    /// </summary>
    [DataContract(Name = "ENSReverseResolveResponse")]
    public partial class ENSReverseResolveResponse : IEquatable<ENSReverseResolveResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ENSReverseResolveResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ENSReverseResolveResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ENSReverseResolveResponse" /> class.
        /// </summary>
        /// <param name="domain">domain (required).</param>
        public ENSReverseResolveResponse(string domain = default(string))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for ENSReverseResolveResponse and cannot be null");
            }
            this.Domain = domain;
        }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ENSReverseResolveResponse {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ENSReverseResolveResponse);
        }

        /// <summary>
        /// Returns true if ENSReverseResolveResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ENSReverseResolveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ENSReverseResolveResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
