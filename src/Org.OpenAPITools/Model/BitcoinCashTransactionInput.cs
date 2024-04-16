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
    /// BitcoinCashTransactionInput
    /// </summary>
    [DataContract(Name = "BitcoinCashTransactionInput")]
    public partial class BitcoinCashTransactionInput : IEquatable<BitcoinCashTransactionInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitcoinCashTransactionInput" /> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="value">value.</param>
        /// <param name="network">network.</param>
        /// <param name="compress">compress.</param>
        public BitcoinCashTransactionInput(string to = default(string), double value = default(double), string network = default(string), bool compress = default(bool))
        {
            this.To = to;
            this.Value = value;
            this.Network = network;
            this.Compress = compress;
        }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets Compress
        /// </summary>
        [DataMember(Name = "compress", EmitDefaultValue = true)]
        public bool Compress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BitcoinCashTransactionInput {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Compress: ").Append(Compress).Append("\n");
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
            return this.Equals(input as BitcoinCashTransactionInput);
        }

        /// <summary>
        /// Returns true if BitcoinCashTransactionInput instances are equal
        /// </summary>
        /// <param name="input">Instance of BitcoinCashTransactionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BitcoinCashTransactionInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Compress == input.Compress ||
                    this.Compress.Equals(input.Compress)
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Compress.GetHashCode();
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
