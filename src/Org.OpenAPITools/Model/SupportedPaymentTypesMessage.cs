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
    /// SupportedPaymentTypesMessage
    /// </summary>
    [DataContract(Name = "SupportedPaymentTypesMessage")]
    public partial class SupportedPaymentTypesMessage : IEquatable<SupportedPaymentTypesMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedPaymentTypesMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedPaymentTypesMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedPaymentTypesMessage" /> class.
        /// </summary>
        /// <param name="googlepay">googlepay (required).</param>
        /// <param name="applepay">applepay (required).</param>
        /// <param name="creditcard">creditcard (required).</param>
        public SupportedPaymentTypesMessage(PaymentType googlepay = default(PaymentType), PaymentType applepay = default(PaymentType), PaymentType creditcard = default(PaymentType))
        {
            // to ensure "googlepay" is required (not null)
            if (googlepay == null)
            {
                throw new ArgumentNullException("googlepay is a required property for SupportedPaymentTypesMessage and cannot be null");
            }
            this.Googlepay = googlepay;
            // to ensure "applepay" is required (not null)
            if (applepay == null)
            {
                throw new ArgumentNullException("applepay is a required property for SupportedPaymentTypesMessage and cannot be null");
            }
            this.Applepay = applepay;
            // to ensure "creditcard" is required (not null)
            if (creditcard == null)
            {
                throw new ArgumentNullException("creditcard is a required property for SupportedPaymentTypesMessage and cannot be null");
            }
            this.Creditcard = creditcard;
        }

        /// <summary>
        /// Gets or Sets Googlepay
        /// </summary>
        [DataMember(Name = "googlepay", IsRequired = true, EmitDefaultValue = true)]
        public PaymentType Googlepay { get; set; }

        /// <summary>
        /// Gets or Sets Applepay
        /// </summary>
        [DataMember(Name = "applepay", IsRequired = true, EmitDefaultValue = true)]
        public PaymentType Applepay { get; set; }

        /// <summary>
        /// Gets or Sets Creditcard
        /// </summary>
        [DataMember(Name = "creditcard", IsRequired = true, EmitDefaultValue = true)]
        public PaymentType Creditcard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedPaymentTypesMessage {\n");
            sb.Append("  Googlepay: ").Append(Googlepay).Append("\n");
            sb.Append("  Applepay: ").Append(Applepay).Append("\n");
            sb.Append("  Creditcard: ").Append(Creditcard).Append("\n");
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
            return this.Equals(input as SupportedPaymentTypesMessage);
        }

        /// <summary>
        /// Returns true if SupportedPaymentTypesMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedPaymentTypesMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedPaymentTypesMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Googlepay == input.Googlepay ||
                    (this.Googlepay != null &&
                    this.Googlepay.Equals(input.Googlepay))
                ) && 
                (
                    this.Applepay == input.Applepay ||
                    (this.Applepay != null &&
                    this.Applepay.Equals(input.Applepay))
                ) && 
                (
                    this.Creditcard == input.Creditcard ||
                    (this.Creditcard != null &&
                    this.Creditcard.Equals(input.Creditcard))
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
                if (this.Googlepay != null)
                {
                    hashCode = (hashCode * 59) + this.Googlepay.GetHashCode();
                }
                if (this.Applepay != null)
                {
                    hashCode = (hashCode * 59) + this.Applepay.GetHashCode();
                }
                if (this.Creditcard != null)
                {
                    hashCode = (hashCode * 59) + this.Creditcard.GetHashCode();
                }
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
