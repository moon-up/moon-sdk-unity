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
    /// CosmosTransactionOutput
    /// </summary>
    [DataContract(Name = "CosmosTransactionOutput")]
    public partial class CosmosTransactionOutput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CosmosTransactionOutput" /> class.
        /// </summary>
        /// <param name="signedTx">signedTx.</param>
        /// <param name="transactionHash">transactionHash.</param>
        public CosmosTransactionOutput(string signedTx = default(string), string transactionHash = default(string))
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
            sb.Append("class CosmosTransactionOutput {\n");
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

    }

}
