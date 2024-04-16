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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NonceResponse
    /// </summary>
    [DataContract(Name = "NonceResponse")]
    public partial class NonceResponse : IEquatable<NonceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NonceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonceResponse" /> class.
        /// </summary>
        /// <param name="nonce">nonce (required).</param>
        public NonceResponse(double nonce = default(double))
        {
            this.Nonce = nonce;
        }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public double Nonce { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NonceResponse {\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as NonceResponse);
        }

        /// <summary>
        /// Returns true if NonceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NonceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
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
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
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
