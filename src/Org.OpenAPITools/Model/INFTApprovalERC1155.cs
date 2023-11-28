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
    /// INFTApprovalERC1155
    /// </summary>
    [DataContract(Name = "INFTApprovalERC1155")]
    public partial class INFTApprovalERC1155 : IEquatable<INFTApprovalERC1155>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="INFTApprovalERC1155" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected INFTApprovalERC1155() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="INFTApprovalERC1155" /> class.
        /// </summary>
        /// <param name="transactionHash">transactionHash (required).</param>
        /// <param name="contract">contract (required).</param>
        /// <param name="logIndex">logIndex (required).</param>
        /// <param name="account">account (required).</param>
        /// <param name="varOperator">varOperator (required).</param>
        /// <param name="approved">approved (required).</param>
        /// <param name="tokenContractType">tokenContractType (required).</param>
        /// <param name="tokenName">tokenName (required).</param>
        /// <param name="tokenSymbol">tokenSymbol (required).</param>
        public INFTApprovalERC1155(string transactionHash = default(string), string contract = default(string), string logIndex = default(string), string account = default(string), string varOperator = default(string), bool approved = default(bool), string tokenContractType = default(string), string tokenName = default(string), string tokenSymbol = default(string))
        {
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.Contract = contract;
            // to ensure "logIndex" is required (not null)
            if (logIndex == null)
            {
                throw new ArgumentNullException("logIndex is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.LogIndex = logIndex;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.Account = account;
            // to ensure "varOperator" is required (not null)
            if (varOperator == null)
            {
                throw new ArgumentNullException("varOperator is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.VarOperator = varOperator;
            this.Approved = approved;
            // to ensure "tokenContractType" is required (not null)
            if (tokenContractType == null)
            {
                throw new ArgumentNullException("tokenContractType is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.TokenContractType = tokenContractType;
            // to ensure "tokenName" is required (not null)
            if (tokenName == null)
            {
                throw new ArgumentNullException("tokenName is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.TokenName = tokenName;
            // to ensure "tokenSymbol" is required (not null)
            if (tokenSymbol == null)
            {
                throw new ArgumentNullException("tokenSymbol is a required property for INFTApprovalERC1155 and cannot be null");
            }
            this.TokenSymbol = tokenSymbol;
        }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [DataMember(Name = "transactionHash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = true)]
        public string Contract { get; set; }

        /// <summary>
        /// Gets or Sets LogIndex
        /// </summary>
        [DataMember(Name = "logIndex", IsRequired = true, EmitDefaultValue = true)]
        public string LogIndex { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets VarOperator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = true)]
        public string VarOperator { get; set; }

        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name = "approved", IsRequired = true, EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or Sets TokenContractType
        /// </summary>
        [DataMember(Name = "tokenContractType", IsRequired = true, EmitDefaultValue = true)]
        public string TokenContractType { get; set; }

        /// <summary>
        /// Gets or Sets TokenName
        /// </summary>
        [DataMember(Name = "tokenName", IsRequired = true, EmitDefaultValue = true)]
        public string TokenName { get; set; }

        /// <summary>
        /// Gets or Sets TokenSymbol
        /// </summary>
        [DataMember(Name = "tokenSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string TokenSymbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class INFTApprovalERC1155 {\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  LogIndex: ").Append(LogIndex).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  VarOperator: ").Append(VarOperator).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  TokenContractType: ").Append(TokenContractType).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
            sb.Append("  TokenSymbol: ").Append(TokenSymbol).Append("\n");
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
            return this.Equals(input as INFTApprovalERC1155);
        }

        /// <summary>
        /// Returns true if INFTApprovalERC1155 instances are equal
        /// </summary>
        /// <param name="input">Instance of INFTApprovalERC1155 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(INFTApprovalERC1155 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.LogIndex == input.LogIndex ||
                    (this.LogIndex != null &&
                    this.LogIndex.Equals(input.LogIndex))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.VarOperator == input.VarOperator ||
                    (this.VarOperator != null &&
                    this.VarOperator.Equals(input.VarOperator))
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.TokenContractType == input.TokenContractType ||
                    (this.TokenContractType != null &&
                    this.TokenContractType.Equals(input.TokenContractType))
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
                ) && 
                (
                    this.TokenSymbol == input.TokenSymbol ||
                    (this.TokenSymbol != null &&
                    this.TokenSymbol.Equals(input.TokenSymbol))
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
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.LogIndex != null)
                {
                    hashCode = (hashCode * 59) + this.LogIndex.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.VarOperator != null)
                {
                    hashCode = (hashCode * 59) + this.VarOperator.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                if (this.TokenContractType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenContractType.GetHashCode();
                }
                if (this.TokenName != null)
                {
                    hashCode = (hashCode * 59) + this.TokenName.GetHashCode();
                }
                if (this.TokenSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.TokenSymbol.GetHashCode();
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
