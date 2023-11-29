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
    /// Erc1155Response
    /// </summary>
    [DataContract(Name = "Erc1155Response")]
    public partial class Erc1155Response : IEquatable<Erc1155Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Erc1155Response" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="chainId">chainId.</param>
        /// <param name="data">data.</param>
        /// <param name="gas">gas.</param>
        /// <param name="gasPrice">gasPrice.</param>
        /// <param name="gasTipCap">gasTipCap.</param>
        /// <param name="gasFeeCap">gasFeeCap.</param>
        /// <param name="value">value.</param>
        /// <param name="nonce">nonce.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="blobGas">blobGas.</param>
        /// <param name="blobGasFeeCap">blobGasFeeCap.</param>
        /// <param name="blobHashes">blobHashes.</param>
        /// <param name="v">v.</param>
        /// <param name="r">r.</param>
        /// <param name="s">s.</param>
        /// <param name="balanceOf">balanceOf.</param>
        /// <param name="balanceOfBatch">balanceOfBatch.</param>
        public Erc1155Response(double type = default(double), double chainId = default(double), string data = default(string), string gas = default(string), string gasPrice = default(string), string gasTipCap = default(string), string gasFeeCap = default(string), string value = default(string), double nonce = default(double), string from = default(string), string to = default(string), string blobGas = default(string), string blobGasFeeCap = default(string), List<string> blobHashes = default(List<string>), string v = default(string), string r = default(string), string s = default(string), string balanceOf = default(string), string balanceOfBatch = default(string))
        {
            this.Type = type;
            this.ChainId = chainId;
            this.Data = data;
            this.Gas = gas;
            this.GasPrice = gasPrice;
            this.GasTipCap = gasTipCap;
            this.GasFeeCap = gasFeeCap;
            this.Value = value;
            this.Nonce = nonce;
            this.From = from;
            this.To = to;
            this.BlobGas = blobGas;
            this.BlobGasFeeCap = blobGasFeeCap;
            this.BlobHashes = blobHashes;
            this.V = v;
            this.R = r;
            this.S = s;
            this.BalanceOf = balanceOf;
            this.BalanceOfBatch = balanceOfBatch;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public double Type { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chain_id", EmitDefaultValue = false)]
        public double ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Gas
        /// </summary>
        [DataMember(Name = "gas", EmitDefaultValue = false)]
        public string Gas { get; set; }

        /// <summary>
        /// Gets or Sets GasPrice
        /// </summary>
        [DataMember(Name = "gas_price", EmitDefaultValue = false)]
        public string GasPrice { get; set; }

        /// <summary>
        /// Gets or Sets GasTipCap
        /// </summary>
        [DataMember(Name = "gas_tip_cap", EmitDefaultValue = true)]
        public string GasTipCap { get; set; }

        /// <summary>
        /// Gets or Sets GasFeeCap
        /// </summary>
        [DataMember(Name = "gas_fee_cap", EmitDefaultValue = true)]
        public string GasFeeCap { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Nonce
        /// </summary>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public double Nonce { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets BlobGas
        /// </summary>
        [DataMember(Name = "blob_gas", EmitDefaultValue = true)]
        public string BlobGas { get; set; }

        /// <summary>
        /// Gets or Sets BlobGasFeeCap
        /// </summary>
        [DataMember(Name = "blob_gas_fee_cap", EmitDefaultValue = true)]
        public string BlobGasFeeCap { get; set; }

        /// <summary>
        /// Gets or Sets BlobHashes
        /// </summary>
        [DataMember(Name = "blob_hashes", EmitDefaultValue = true)]
        public List<string> BlobHashes { get; set; }

        /// <summary>
        /// Gets or Sets V
        /// </summary>
        [DataMember(Name = "v", EmitDefaultValue = false)]
        public string V { get; set; }

        /// <summary>
        /// Gets or Sets R
        /// </summary>
        [DataMember(Name = "r", EmitDefaultValue = false)]
        public string R { get; set; }

        /// <summary>
        /// Gets or Sets S
        /// </summary>
        [DataMember(Name = "s", EmitDefaultValue = false)]
        public string S { get; set; }

        /// <summary>
        /// Gets or Sets BalanceOf
        /// </summary>
        [DataMember(Name = "balance_of", EmitDefaultValue = false)]
        public string BalanceOf { get; set; }

        /// <summary>
        /// Gets or Sets BalanceOfBatch
        /// </summary>
        [DataMember(Name = "balance_of_batch", EmitDefaultValue = false)]
        public string BalanceOfBatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Erc1155Response {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Gas: ").Append(Gas).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  GasTipCap: ").Append(GasTipCap).Append("\n");
            sb.Append("  GasFeeCap: ").Append(GasFeeCap).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  BlobGas: ").Append(BlobGas).Append("\n");
            sb.Append("  BlobGasFeeCap: ").Append(BlobGasFeeCap).Append("\n");
            sb.Append("  BlobHashes: ").Append(BlobHashes).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
            sb.Append("  BalanceOf: ").Append(BalanceOf).Append("\n");
            sb.Append("  BalanceOfBatch: ").Append(BalanceOfBatch).Append("\n");
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
            return this.Equals(input as Erc1155Response);
        }

        /// <summary>
        /// Returns true if Erc1155Response instances are equal
        /// </summary>
        /// <param name="input">Instance of Erc1155Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Erc1155Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                    this.GasTipCap == input.GasTipCap ||
                    (this.GasTipCap != null &&
                    this.GasTipCap.Equals(input.GasTipCap))
                ) && 
                (
                    this.GasFeeCap == input.GasFeeCap ||
                    (this.GasFeeCap != null &&
                    this.GasFeeCap.Equals(input.GasFeeCap))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.BlobGas == input.BlobGas ||
                    (this.BlobGas != null &&
                    this.BlobGas.Equals(input.BlobGas))
                ) && 
                (
                    this.BlobGasFeeCap == input.BlobGasFeeCap ||
                    (this.BlobGasFeeCap != null &&
                    this.BlobGasFeeCap.Equals(input.BlobGasFeeCap))
                ) && 
                (
                    this.BlobHashes == input.BlobHashes ||
                    this.BlobHashes != null &&
                    input.BlobHashes != null &&
                    this.BlobHashes.SequenceEqual(input.BlobHashes)
                ) && 
                (
                    this.V == input.V ||
                    (this.V != null &&
                    this.V.Equals(input.V))
                ) && 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.S == input.S ||
                    (this.S != null &&
                    this.S.Equals(input.S))
                ) && 
                (
                    this.BalanceOf == input.BalanceOf ||
                    (this.BalanceOf != null &&
                    this.BalanceOf.Equals(input.BalanceOf))
                ) && 
                (
                    this.BalanceOfBatch == input.BalanceOfBatch ||
                    (this.BalanceOfBatch != null &&
                    this.BalanceOfBatch.Equals(input.BalanceOfBatch))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Gas != null)
                {
                    hashCode = (hashCode * 59) + this.Gas.GetHashCode();
                }
                if (this.GasPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GasPrice.GetHashCode();
                }
                if (this.GasTipCap != null)
                {
                    hashCode = (hashCode * 59) + this.GasTipCap.GetHashCode();
                }
                if (this.GasFeeCap != null)
                {
                    hashCode = (hashCode * 59) + this.GasFeeCap.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.BlobGas != null)
                {
                    hashCode = (hashCode * 59) + this.BlobGas.GetHashCode();
                }
                if (this.BlobGasFeeCap != null)
                {
                    hashCode = (hashCode * 59) + this.BlobGasFeeCap.GetHashCode();
                }
                if (this.BlobHashes != null)
                {
                    hashCode = (hashCode * 59) + this.BlobHashes.GetHashCode();
                }
                if (this.V != null)
                {
                    hashCode = (hashCode * 59) + this.V.GetHashCode();
                }
                if (this.R != null)
                {
                    hashCode = (hashCode * 59) + this.R.GetHashCode();
                }
                if (this.S != null)
                {
                    hashCode = (hashCode * 59) + this.S.GetHashCode();
                }
                if (this.BalanceOf != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceOf.GetHashCode();
                }
                if (this.BalanceOfBatch != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceOfBatch.GetHashCode();
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
