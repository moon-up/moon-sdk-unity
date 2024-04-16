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
    /// SolanaTransactionOutput
    /// </summary>
    [DataContract(Name = "SolanaTransactionOutput")]
    public partial class SolanaTransactionOutput : IEquatable<SolanaTransactionOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaTransactionOutput" /> class.
        /// </summary>
        /// <param name="signedTx">signedTx.</param>
        /// <param name="transactionHash">transactionHash.</param>
        public SolanaTransactionOutput(string signedTx = default(string), string transactionHash = default(string))
        {
            this.SignedTx = signedTx;
            this.TransactionHash = transactionHash;
        }

        /// <summary>
        /// Gets or Sets SignedTx
        /// </summary>
        [DataMember(Name = "signedTx", EmitDefaultValue = false)]
        public string SignedTx { get; set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [DataMember(Name = "transaction_hash", EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SolanaTransactionOutput {\n");
            sb.Append("  SignedTx: ").Append(SignedTx).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
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
            return this.Equals(input as SolanaTransactionOutput);
        }

        /// <summary>
        /// Returns true if SolanaTransactionOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of SolanaTransactionOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolanaTransactionOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignedTx == input.SignedTx ||
                    (this.SignedTx != null &&
                    this.SignedTx.Equals(input.SignedTx))
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
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
                if (this.SignedTx != null)
                {
                    hashCode = (hashCode * 59) + this.SignedTx.GetHashCode();
                }
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
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
