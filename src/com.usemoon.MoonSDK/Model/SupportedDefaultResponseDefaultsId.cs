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
    /// SupportedDefaultResponseDefaultsId
    /// </summary>
    [DataContract(Name = "SupportedDefaultResponse_defaults_id")]
    public partial class SupportedDefaultResponseDefaultsId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDefaultResponseDefaultsId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedDefaultResponseDefaultsId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDefaultResponseDefaultsId" /> class.
        /// </summary>
        /// <param name="provider">provider (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="target">target (required).</param>
        /// <param name="source">source (required).</param>
        public SupportedDefaultResponseDefaultsId(string provider = default(string), string paymentMethod = default(string), double amount = default(double), string target = default(string), string source = default(string))
        {
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new ArgumentNullException("provider is a required property for SupportedDefaultResponseDefaultsId and cannot be null");
            }
            this.Provider = provider;
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for SupportedDefaultResponseDefaultsId and cannot be null");
            }
            this.PaymentMethod = paymentMethod;
            this.Amount = amount;
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new ArgumentNullException("target is a required property for SupportedDefaultResponseDefaultsId and cannot be null");
            }
            this.Target = target;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for SupportedDefaultResponseDefaultsId and cannot be null");
            }
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedDefaultResponseDefaultsId {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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

    }

}
