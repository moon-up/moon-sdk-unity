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
    /// TokenSwapParams
    /// </summary>
    [DataContract(Name = "TokenSwapParams")]
    public partial class TokenSwapParams : IEquatable<TokenSwapParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenSwapParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenSwapParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenSwapParams" /> class.
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
        /// <param name="tokenIn">tokenIn (required).</param>
        /// <param name="tokenOut">tokenOut (required).</param>
        /// <param name="tokenInDecimals">tokenInDecimals (required).</param>
        /// <param name="tokenOutDecimals">tokenOutDecimals (required).</param>
        /// <param name="amountIn">amountIn (required).</param>
        /// <param name="slippage">slippage (required).</param>
        /// <param name="recipient">recipient (required).</param>
        /// <param name="referrer">referrer (required).</param>
        public TokenSwapParams(string to = default(string), string data = default(string), string input = default(string), string value = default(string), string nonce = default(string), string gas = default(string), string gasPrice = default(string), string chainId = default(string), string encoding = default(string), bool eOA = default(bool), string contractAddress = default(string), string tokenId = default(string), string tokenIds = default(string), bool approved = default(bool), bool broadcast = default(bool), string tokenIn = default(string), string tokenOut = default(string), double tokenInDecimals = default(double), double tokenOutDecimals = default(double), string amountIn = default(string), string slippage = default(string), string recipient = default(string), string referrer = default(string))
        {
            // to ensure "tokenIn" is required (not null)
            if (tokenIn == null)
            {
                throw new ArgumentNullException("tokenIn is a required property for TokenSwapParams and cannot be null");
            }
            this.TokenIn = tokenIn;
            // to ensure "tokenOut" is required (not null)
            if (tokenOut == null)
            {
                throw new ArgumentNullException("tokenOut is a required property for TokenSwapParams and cannot be null");
            }
            this.TokenOut = tokenOut;
            this.TokenInDecimals = tokenInDecimals;
            this.TokenOutDecimals = tokenOutDecimals;
            // to ensure "amountIn" is required (not null)
            if (amountIn == null)
            {
                throw new ArgumentNullException("amountIn is a required property for TokenSwapParams and cannot be null");
            }
            this.AmountIn = amountIn;
            // to ensure "slippage" is required (not null)
            if (slippage == null)
            {
                throw new ArgumentNullException("slippage is a required property for TokenSwapParams and cannot be null");
            }
            this.Slippage = slippage;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for TokenSwapParams and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "referrer" is required (not null)
            if (referrer == null)
            {
                throw new ArgumentNullException("referrer is a required property for TokenSwapParams and cannot be null");
            }
            this.Referrer = referrer;
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
        /// Gets or Sets TokenIn
        /// </summary>
        [DataMember(Name = "tokenIn", IsRequired = true, EmitDefaultValue = true)]
        public string TokenIn { get; set; }

        /// <summary>
        /// Gets or Sets TokenOut
        /// </summary>
        [DataMember(Name = "tokenOut", IsRequired = true, EmitDefaultValue = true)]
        public string TokenOut { get; set; }

        /// <summary>
        /// Gets or Sets TokenInDecimals
        /// </summary>
        [DataMember(Name = "tokenInDecimals", IsRequired = true, EmitDefaultValue = true)]
        public double TokenInDecimals { get; set; }

        /// <summary>
        /// Gets or Sets TokenOutDecimals
        /// </summary>
        [DataMember(Name = "tokenOutDecimals", IsRequired = true, EmitDefaultValue = true)]
        public double TokenOutDecimals { get; set; }

        /// <summary>
        /// Gets or Sets AmountIn
        /// </summary>
        [DataMember(Name = "amountIn", IsRequired = true, EmitDefaultValue = true)]
        public string AmountIn { get; set; }

        /// <summary>
        /// Gets or Sets Slippage
        /// </summary>
        [DataMember(Name = "slippage", IsRequired = true, EmitDefaultValue = true)]
        public string Slippage { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = true)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets Referrer
        /// </summary>
        [DataMember(Name = "referrer", IsRequired = true, EmitDefaultValue = true)]
        public string Referrer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenSwapParams {\n");
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
            sb.Append("  TokenIn: ").Append(TokenIn).Append("\n");
            sb.Append("  TokenOut: ").Append(TokenOut).Append("\n");
            sb.Append("  TokenInDecimals: ").Append(TokenInDecimals).Append("\n");
            sb.Append("  TokenOutDecimals: ").Append(TokenOutDecimals).Append("\n");
            sb.Append("  AmountIn: ").Append(AmountIn).Append("\n");
            sb.Append("  Slippage: ").Append(Slippage).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
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
            return this.Equals(input as TokenSwapParams);
        }

        /// <summary>
        /// Returns true if TokenSwapParams instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenSwapParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenSwapParams input)
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
                    this.TokenIn == input.TokenIn ||
                    (this.TokenIn != null &&
                    this.TokenIn.Equals(input.TokenIn))
                ) && 
                (
                    this.TokenOut == input.TokenOut ||
                    (this.TokenOut != null &&
                    this.TokenOut.Equals(input.TokenOut))
                ) && 
                (
                    this.TokenInDecimals == input.TokenInDecimals ||
                    this.TokenInDecimals.Equals(input.TokenInDecimals)
                ) && 
                (
                    this.TokenOutDecimals == input.TokenOutDecimals ||
                    this.TokenOutDecimals.Equals(input.TokenOutDecimals)
                ) && 
                (
                    this.AmountIn == input.AmountIn ||
                    (this.AmountIn != null &&
                    this.AmountIn.Equals(input.AmountIn))
                ) && 
                (
                    this.Slippage == input.Slippage ||
                    (this.Slippage != null &&
                    this.Slippage.Equals(input.Slippage))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Referrer == input.Referrer ||
                    (this.Referrer != null &&
                    this.Referrer.Equals(input.Referrer))
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
                if (this.TokenIn != null)
                {
                    hashCode = (hashCode * 59) + this.TokenIn.GetHashCode();
                }
                if (this.TokenOut != null)
                {
                    hashCode = (hashCode * 59) + this.TokenOut.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenInDecimals.GetHashCode();
                hashCode = (hashCode * 59) + this.TokenOutDecimals.GetHashCode();
                if (this.AmountIn != null)
                {
                    hashCode = (hashCode * 59) + this.AmountIn.GetHashCode();
                }
                if (this.Slippage != null)
                {
                    hashCode = (hashCode * 59) + this.Slippage.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.Referrer != null)
                {
                    hashCode = (hashCode * 59) + this.Referrer.GetHashCode();
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
