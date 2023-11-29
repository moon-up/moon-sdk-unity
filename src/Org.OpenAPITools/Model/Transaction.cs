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
    /// Transaction
    /// </summary>
    [DataContract(Name = "Transaction")]
    public partial class Transaction : IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="useropTransaction">useropTransaction.</param>
        /// <param name="userOps">userOps.</param>
        /// <param name="varTransaction">varTransaction.</param>
        /// <param name="signature">signature.</param>
        /// <param name="moonScanUrl">moonScanUrl.</param>
        /// <param name="transactions">transactions.</param>
        /// <param name="data">data.</param>
        /// <param name="rawTransaction">rawTransaction.</param>
        /// <param name="signedTransaction">signedTransaction.</param>
        /// <param name="transactionHash">transactionHash.</param>
        public Transaction(string useropTransaction = default(string), List<TransactionRequest> userOps = default(List<TransactionRequest>), Tx varTransaction = default(Tx), string signature = default(string), string moonScanUrl = default(string), List<TransactionData> transactions = default(List<TransactionData>), string data = default(string), string rawTransaction = default(string), string signedTransaction = default(string), string transactionHash = default(string))
        {
            this.UseropTransaction = useropTransaction;
            this.UserOps = userOps;
            this.VarTransaction = varTransaction;
            this.Signature = signature;
            this.MoonScanUrl = moonScanUrl;
            this.Transactions = transactions;
            this.Data = data;
            this.RawTransaction = rawTransaction;
            this.SignedTransaction = signedTransaction;
            this.TransactionHash = transactionHash;
        }

        /// <summary>
        /// Gets or Sets UseropTransaction
        /// </summary>
        [DataMember(Name = "userop_transaction", EmitDefaultValue = false)]
        public string UseropTransaction { get; set; }

        /// <summary>
        /// Gets or Sets UserOps
        /// </summary>
        [DataMember(Name = "userOps", EmitDefaultValue = false)]
        public List<TransactionRequest> UserOps { get; set; }

        /// <summary>
        /// Gets or Sets VarTransaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Tx VarTransaction { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets MoonScanUrl
        /// </summary>
        [DataMember(Name = "moon_scan_url", EmitDefaultValue = false)]
        public string MoonScanUrl { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<TransactionData> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets RawTransaction
        /// </summary>
        [DataMember(Name = "raw_transaction", EmitDefaultValue = false)]
        public string RawTransaction { get; set; }

        /// <summary>
        /// Gets or Sets SignedTransaction
        /// </summary>
        [DataMember(Name = "signed_transaction", EmitDefaultValue = false)]
        public string SignedTransaction { get; set; }

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
            sb.Append("class Transaction {\n");
            sb.Append("  UseropTransaction: ").Append(UseropTransaction).Append("\n");
            sb.Append("  UserOps: ").Append(UserOps).Append("\n");
            sb.Append("  VarTransaction: ").Append(VarTransaction).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  MoonScanUrl: ").Append(MoonScanUrl).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  RawTransaction: ").Append(RawTransaction).Append("\n");
            sb.Append("  SignedTransaction: ").Append(SignedTransaction).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UseropTransaction == input.UseropTransaction ||
                    (this.UseropTransaction != null &&
                    this.UseropTransaction.Equals(input.UseropTransaction))
                ) && 
                (
                    this.UserOps == input.UserOps ||
                    this.UserOps != null &&
                    input.UserOps != null &&
                    this.UserOps.SequenceEqual(input.UserOps)
                ) && 
                (
                    this.VarTransaction == input.VarTransaction ||
                    (this.VarTransaction != null &&
                    this.VarTransaction.Equals(input.VarTransaction))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.MoonScanUrl == input.MoonScanUrl ||
                    (this.MoonScanUrl != null &&
                    this.MoonScanUrl.Equals(input.MoonScanUrl))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.RawTransaction == input.RawTransaction ||
                    (this.RawTransaction != null &&
                    this.RawTransaction.Equals(input.RawTransaction))
                ) && 
                (
                    this.SignedTransaction == input.SignedTransaction ||
                    (this.SignedTransaction != null &&
                    this.SignedTransaction.Equals(input.SignedTransaction))
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
                if (this.UseropTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.UseropTransaction.GetHashCode();
                }
                if (this.UserOps != null)
                {
                    hashCode = (hashCode * 59) + this.UserOps.GetHashCode();
                }
                if (this.VarTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.VarTransaction.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.MoonScanUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MoonScanUrl.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.RawTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.RawTransaction.GetHashCode();
                }
                if (this.SignedTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.SignedTransaction.GetHashCode();
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
