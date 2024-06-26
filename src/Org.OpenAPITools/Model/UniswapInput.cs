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
    /// UniswapInput
    /// </summary>
    [DataContract(Name = "UniswapInput")]
    public partial class UniswapInput : IEquatable<UniswapInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniswapInput" /> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="data">data.</param>
        /// <param name="input">input.</param>
        /// <param name="value">value.</param>
        /// <param name="nonce">nonce.</param>
        /// <param name="gas">gas.</param>
        /// <param name="gasPrice">gasPrice.</param>
        /// <param name="chainId">chainId.</param>
        /// <param name="encoding">encoding.</param>
        /// <param name="eOA">eOA.</param>
        /// <param name="contractAddress">contractAddress.</param>
        /// <param name="tokenId">tokenId.</param>
        /// <param name="tokenIds">tokenIds.</param>
        /// <param name="approved">approved.</param>
        /// <param name="broadcast">broadcast.</param>
        /// <param name="tokenA">tokenA.</param>
        /// <param name="tokenB">tokenB.</param>
        /// <param name="amountA">amountA.</param>
        /// <param name="amountB">amountB.</param>
        public UniswapInput(string to = default(string), string data = default(string), string input = default(string), string value = default(string), string nonce = default(string), string gas = default(string), string gasPrice = default(string), string chainId = default(string), string encoding = default(string), bool eOA = default(bool), string contractAddress = default(string), string tokenId = default(string), string tokenIds = default(string), bool approved = default(bool), bool broadcast = default(bool), string tokenA = default(string), string tokenB = default(string), string amountA = default(string), string amountB = default(string))
        {
            this.To = to;
            this.Data = data;
            this.Input = input;
            this.Value = value;
            this.Nonce = nonce;
            this.Gas = gas;
            this.GasPrice = gasPrice;
            this.ChainId = chainId;
            this.Encoding = encoding;
            this.EOA = eOA;
            this.ContractAddress = contractAddress;
            this.TokenId = tokenId;
            this.TokenIds = tokenIds;
            this.Approved = approved;
            this.Broadcast = broadcast;
            this.TokenA = tokenA;
            this.TokenB = tokenB;
            this.AmountA = amountA;
            this.AmountB = amountB;
        }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public string Input { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or Sets Gas
        /// </summary>
        [DataMember(Name = "gas", EmitDefaultValue = false)]
        public string Gas { get; set; }

        /// <summary>
        /// Gets or Sets GasPrice
        /// </summary>
        [DataMember(Name = "gasPrice", EmitDefaultValue = false)]
        public string GasPrice { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chain_id", EmitDefaultValue = false)]
        public string ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Encoding
        /// </summary>
        [DataMember(Name = "encoding", EmitDefaultValue = false)]
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or Sets EOA
        /// </summary>
        [DataMember(Name = "EOA", EmitDefaultValue = true)]
        public bool EOA { get; set; }

        /// <summary>
        /// Gets or Sets ContractAddress
        /// </summary>
        [DataMember(Name = "contract_address", EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [DataMember(Name = "token_id", EmitDefaultValue = false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Gets or Sets TokenIds
        /// </summary>
        [DataMember(Name = "token_ids", EmitDefaultValue = false)]
        public string TokenIds { get; set; }

        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name = "approved", EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or Sets Broadcast
        /// </summary>
        [DataMember(Name = "broadcast", EmitDefaultValue = true)]
        public bool Broadcast { get; set; }

        /// <summary>
        /// Gets or Sets TokenA
        /// </summary>
        [DataMember(Name = "token_a", EmitDefaultValue = false)]
        public string TokenA { get; set; }

        /// <summary>
        /// Gets or Sets TokenB
        /// </summary>
        [DataMember(Name = "token_b", EmitDefaultValue = false)]
        public string TokenB { get; set; }

        /// <summary>
        /// Gets or Sets AmountA
        /// </summary>
        [DataMember(Name = "amount_a", EmitDefaultValue = false)]
        public string AmountA { get; set; }

        /// <summary>
        /// Gets or Sets AmountB
        /// </summary>
        [DataMember(Name = "amount_b", EmitDefaultValue = false)]
        public string AmountB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UniswapInput {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Gas: ").Append(Gas).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  EOA: ").Append(EOA).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TokenIds: ").Append(TokenIds).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Broadcast: ").Append(Broadcast).Append("\n");
            sb.Append("  TokenA: ").Append(TokenA).Append("\n");
            sb.Append("  TokenB: ").Append(TokenB).Append("\n");
            sb.Append("  AmountA: ").Append(AmountA).Append("\n");
            sb.Append("  AmountB: ").Append(AmountB).Append("\n");
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
            return this.Equals(input as UniswapInput);
        }

        /// <summary>
        /// Returns true if UniswapInput instances are equal
        /// </summary>
        /// <param name="input">Instance of UniswapInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UniswapInput input)
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
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Gas == input.Gas ||
                    (this.Gas != null &&
                    this.Gas.Equals(input.Gas))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    (this.ChainId != null &&
                    this.ChainId.Equals(input.ChainId))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    (this.Encoding != null &&
                    this.Encoding.Equals(input.Encoding))
                ) && 
                (
                    this.EOA == input.EOA ||
                    this.EOA.Equals(input.EOA)
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TokenIds == input.TokenIds ||
                    (this.TokenIds != null &&
                    this.TokenIds.Equals(input.TokenIds))
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.Broadcast == input.Broadcast ||
                    this.Broadcast.Equals(input.Broadcast)
                ) && 
                (
                    this.TokenA == input.TokenA ||
                    (this.TokenA != null &&
                    this.TokenA.Equals(input.TokenA))
                ) && 
                (
                    this.TokenB == input.TokenB ||
                    (this.TokenB != null &&
                    this.TokenB.Equals(input.TokenB))
                ) && 
                (
                    this.AmountA == input.AmountA ||
                    (this.AmountA != null &&
                    this.AmountA.Equals(input.AmountA))
                ) && 
                (
                    this.AmountB == input.AmountB ||
                    (this.AmountB != null &&
                    this.AmountB.Equals(input.AmountB))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.Gas != null)
                {
                    hashCode = (hashCode * 59) + this.Gas.GetHashCode();
                }
                if (this.GasPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GasPrice.GetHashCode();
                }
                if (this.ChainId != null)
                {
                    hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                }
                if (this.Encoding != null)
                {
                    hashCode = (hashCode * 59) + this.Encoding.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EOA.GetHashCode();
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.TokenIds != null)
                {
                    hashCode = (hashCode * 59) + this.TokenIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                hashCode = (hashCode * 59) + this.Broadcast.GetHashCode();
                if (this.TokenA != null)
                {
                    hashCode = (hashCode * 59) + this.TokenA.GetHashCode();
                }
                if (this.TokenB != null)
                {
                    hashCode = (hashCode * 59) + this.TokenB.GetHashCode();
                }
                if (this.AmountA != null)
                {
                    hashCode = (hashCode * 59) + this.AmountA.GetHashCode();
                }
                if (this.AmountB != null)
                {
                    hashCode = (hashCode * 59) + this.AmountB.GetHashCode();
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
