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
    /// TransactionResponse
    /// </summary>
    [DataContract(Name = "TransactionResponse")]
    public partial class TransactionResponse : IEquatable<TransactionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponse" /> class.
        /// </summary>
        /// <param name="message">message (required).</param>
        /// <param name="tx">tx (required).</param>
        /// <param name="info">info (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="currentBlockNumber">currentBlockNumber (required).</param>
        public TransactionResponse(string message = default(string), TransactionResponseTx tx = default(TransactionResponseTx), TransactionResponseInfo info = default(TransactionResponseInfo), double chainId = default(double), double currentBlockNumber = default(double))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for TransactionResponse and cannot be null");
            }
            this.Message = message;
            // to ensure "tx" is required (not null)
            if (tx == null)
            {
                throw new ArgumentNullException("tx is a required property for TransactionResponse and cannot be null");
            }
            this.Tx = tx;
            // to ensure "info" is required (not null)
            if (info == null)
            {
                throw new ArgumentNullException("info is a required property for TransactionResponse and cannot be null");
            }
            this.Info = info;
            this.ChainId = chainId;
            this.CurrentBlockNumber = currentBlockNumber;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Tx
        /// </summary>
        [DataMember(Name = "tx", IsRequired = true, EmitDefaultValue = true)]
        public TransactionResponseTx Tx { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", IsRequired = true, EmitDefaultValue = true)]
        public TransactionResponseInfo Info { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public double ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBlockNumber
        /// </summary>
        [DataMember(Name = "currentBlockNumber", IsRequired = true, EmitDefaultValue = true)]
        public double CurrentBlockNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Tx: ").Append(Tx).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CurrentBlockNumber: ").Append(CurrentBlockNumber).Append("\n");
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
            return this.Equals(input as TransactionResponse);
        }

        /// <summary>
        /// Returns true if TransactionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionResponse input)
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
                ) && 
                (
                    this.Tx == input.Tx ||
                    (this.Tx != null &&
                    this.Tx.Equals(input.Tx))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.CurrentBlockNumber == input.CurrentBlockNumber ||
                    this.CurrentBlockNumber.Equals(input.CurrentBlockNumber)
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
                if (this.Tx != null)
                {
                    hashCode = (hashCode * 59) + this.Tx.GetHashCode();
                }
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentBlockNumber.GetHashCode();
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
