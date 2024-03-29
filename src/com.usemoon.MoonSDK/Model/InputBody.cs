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
    /// InputBody
    /// </summary>
    [DataContract(Name = "InputBody")]
    public partial class InputBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputBody" /> class.
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
        public InputBody(string to = default(string), string data = default(string), string input = default(string), string value = default(string), string nonce = default(string), string gas = default(string), string gasPrice = default(string), string chainId = default(string), string encoding = default(string), bool eOA = default(bool), string contractAddress = default(string), string tokenId = default(string), string tokenIds = default(string), bool approved = default(bool), bool broadcast = default(bool))
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InputBody {\n");
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
