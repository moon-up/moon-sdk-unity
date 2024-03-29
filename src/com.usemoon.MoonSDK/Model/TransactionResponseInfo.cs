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
    /// TransactionResponseInfo
    /// </summary>
    [DataContract(Name = "TransactionResponse_info")]
    public partial class TransactionResponseInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponseInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionResponseInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponseInfo" /> class.
        /// </summary>
        /// <param name="conveyorGas">conveyorGas (required).</param>
        /// <param name="affiliateGas">affiliateGas (required).</param>
        /// <param name="affiliateAggregator">affiliateAggregator (required).</param>
        /// <param name="amountOut">amountOut (required).</param>
        /// <param name="amountOutMin">amountOutMin (required).</param>
        public TransactionResponseInfo(string conveyorGas = default(string), string affiliateGas = default(string), string affiliateAggregator = default(string), string amountOut = default(string), string amountOutMin = default(string))
        {
            // to ensure "conveyorGas" is required (not null)
            if (conveyorGas == null)
            {
                throw new ArgumentNullException("conveyorGas is a required property for TransactionResponseInfo and cannot be null");
            }
            this.ConveyorGas = conveyorGas;
            // to ensure "affiliateGas" is required (not null)
            if (affiliateGas == null)
            {
                throw new ArgumentNullException("affiliateGas is a required property for TransactionResponseInfo and cannot be null");
            }
            this.AffiliateGas = affiliateGas;
            // to ensure "affiliateAggregator" is required (not null)
            if (affiliateAggregator == null)
            {
                throw new ArgumentNullException("affiliateAggregator is a required property for TransactionResponseInfo and cannot be null");
            }
            this.AffiliateAggregator = affiliateAggregator;
            // to ensure "amountOut" is required (not null)
            if (amountOut == null)
            {
                throw new ArgumentNullException("amountOut is a required property for TransactionResponseInfo and cannot be null");
            }
            this.AmountOut = amountOut;
            // to ensure "amountOutMin" is required (not null)
            if (amountOutMin == null)
            {
                throw new ArgumentNullException("amountOutMin is a required property for TransactionResponseInfo and cannot be null");
            }
            this.AmountOutMin = amountOutMin;
        }

        /// <summary>
        /// Gets or Sets ConveyorGas
        /// </summary>
        [DataMember(Name = "conveyorGas", IsRequired = true, EmitDefaultValue = true)]
        public string ConveyorGas { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateGas
        /// </summary>
        [DataMember(Name = "affiliateGas", IsRequired = true, EmitDefaultValue = true)]
        public string AffiliateGas { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateAggregator
        /// </summary>
        [DataMember(Name = "affiliateAggregator", IsRequired = true, EmitDefaultValue = true)]
        public string AffiliateAggregator { get; set; }

        /// <summary>
        /// Gets or Sets AmountOut
        /// </summary>
        [DataMember(Name = "amountOut", IsRequired = true, EmitDefaultValue = true)]
        public string AmountOut { get; set; }

        /// <summary>
        /// Gets or Sets AmountOutMin
        /// </summary>
        [DataMember(Name = "amountOutMin", IsRequired = true, EmitDefaultValue = true)]
        public string AmountOutMin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionResponseInfo {\n");
            sb.Append("  ConveyorGas: ").Append(ConveyorGas).Append("\n");
            sb.Append("  AffiliateGas: ").Append(AffiliateGas).Append("\n");
            sb.Append("  AffiliateAggregator: ").Append(AffiliateAggregator).Append("\n");
            sb.Append("  AmountOut: ").Append(AmountOut).Append("\n");
            sb.Append("  AmountOutMin: ").Append(AmountOutMin).Append("\n");
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
