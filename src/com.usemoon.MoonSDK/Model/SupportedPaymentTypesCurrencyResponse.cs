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
    /// SupportedPaymentTypesCurrencyResponse
    /// </summary>
    [DataContract(Name = "SupportedPaymentTypesCurrencyResponse")]
    public partial class SupportedPaymentTypesCurrencyResponse : IEquatable<SupportedPaymentTypesCurrencyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedPaymentTypesCurrencyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedPaymentTypesCurrencyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedPaymentTypesCurrencyResponse" /> class.
        /// </summary>
        /// <param name="message">message (required).</param>
        public SupportedPaymentTypesCurrencyResponse(SupportedPaymentTypesMessage message = default(SupportedPaymentTypesMessage))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SupportedPaymentTypesCurrencyResponse and cannot be null");
            }
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public SupportedPaymentTypesMessage Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedPaymentTypesCurrencyResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as SupportedPaymentTypesCurrencyResponse);
        }

        /// <summary>
        /// Returns true if SupportedPaymentTypesCurrencyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedPaymentTypesCurrencyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedPaymentTypesCurrencyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}