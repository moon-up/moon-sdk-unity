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
    /// Log
    /// </summary>
    [DataContract(Name = "Log")]
    public partial class Log : IEquatable<Log>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Log() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Log" /> class.
        /// </summary>
        /// <param name="triggers">triggers.</param>
        /// <param name="logIndex">logIndex (required).</param>
        /// <param name="transactionHash">transactionHash (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="topic0">topic0 (required).</param>
        /// <param name="topic1">topic1 (required).</param>
        /// <param name="topic2">topic2 (required).</param>
        /// <param name="topic3">topic3 (required).</param>
        public Log(List<TriggerOutput> triggers = default(List<TriggerOutput>), string logIndex = default(string), string transactionHash = default(string), string address = default(string), string data = default(string), string topic0 = default(string), string topic1 = default(string), string topic2 = default(string), string topic3 = default(string))
        {
            // to ensure "logIndex" is required (not null)
            if (logIndex == null)
            {
                throw new ArgumentNullException("logIndex is a required property for Log and cannot be null");
            }
            this.LogIndex = logIndex;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for Log and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for Log and cannot be null");
            }
            this.Address = address;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for Log and cannot be null");
            }
            this.Data = data;
            // to ensure "topic0" is required (not null)
            if (topic0 == null)
            {
                throw new ArgumentNullException("topic0 is a required property for Log and cannot be null");
            }
            this.Topic0 = topic0;
            // to ensure "topic1" is required (not null)
            if (topic1 == null)
            {
                throw new ArgumentNullException("topic1 is a required property for Log and cannot be null");
            }
            this.Topic1 = topic1;
            // to ensure "topic2" is required (not null)
            if (topic2 == null)
            {
                throw new ArgumentNullException("topic2 is a required property for Log and cannot be null");
            }
            this.Topic2 = topic2;
            // to ensure "topic3" is required (not null)
            if (topic3 == null)
            {
                throw new ArgumentNullException("topic3 is a required property for Log and cannot be null");
            }
            this.Topic3 = topic3;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Gets or Sets Triggers
        /// </summary>
        [DataMember(Name = "triggers", EmitDefaultValue = false)]
        public List<TriggerOutput> Triggers { get; set; }

        /// <summary>
        /// Gets or Sets LogIndex
        /// </summary>
        [DataMember(Name = "logIndex", IsRequired = true, EmitDefaultValue = true)]
        public string LogIndex { get; set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [DataMember(Name = "transactionHash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Topic0
        /// </summary>
        [DataMember(Name = "topic0", IsRequired = true, EmitDefaultValue = true)]
        public string Topic0 { get; set; }

        /// <summary>
        /// Gets or Sets Topic1
        /// </summary>
        [DataMember(Name = "topic1", IsRequired = true, EmitDefaultValue = true)]
        public string Topic1 { get; set; }

        /// <summary>
        /// Gets or Sets Topic2
        /// </summary>
        [DataMember(Name = "topic2", IsRequired = true, EmitDefaultValue = true)]
        public string Topic2 { get; set; }

        /// <summary>
        /// Gets or Sets Topic3
        /// </summary>
        [DataMember(Name = "topic3", IsRequired = true, EmitDefaultValue = true)]
        public string Topic3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Log {\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  LogIndex: ").Append(LogIndex).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Topic0: ").Append(Topic0).Append("\n");
            sb.Append("  Topic1: ").Append(Topic1).Append("\n");
            sb.Append("  Topic2: ").Append(Topic2).Append("\n");
            sb.Append("  Topic3: ").Append(Topic3).Append("\n");
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
            return this.Equals(input as Log);
        }

        /// <summary>
        /// Returns true if Log instances are equal
        /// </summary>
        /// <param name="input">Instance of Log to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Log input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.LogIndex == input.LogIndex ||
                    (this.LogIndex != null &&
                    this.LogIndex.Equals(input.LogIndex))
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Topic0 == input.Topic0 ||
                    (this.Topic0 != null &&
                    this.Topic0.Equals(input.Topic0))
                ) && 
                (
                    this.Topic1 == input.Topic1 ||
                    (this.Topic1 != null &&
                    this.Topic1.Equals(input.Topic1))
                ) && 
                (
                    this.Topic2 == input.Topic2 ||
                    (this.Topic2 != null &&
                    this.Topic2.Equals(input.Topic2))
                ) && 
                (
                    this.Topic3 == input.Topic3 ||
                    (this.Topic3 != null &&
                    this.Topic3.Equals(input.Topic3))
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
                if (this.Triggers != null)
                {
                    hashCode = (hashCode * 59) + this.Triggers.GetHashCode();
                }
                if (this.LogIndex != null)
                {
                    hashCode = (hashCode * 59) + this.LogIndex.GetHashCode();
                }
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Topic0 != null)
                {
                    hashCode = (hashCode * 59) + this.Topic0.GetHashCode();
                }
                if (this.Topic1 != null)
                {
                    hashCode = (hashCode * 59) + this.Topic1.GetHashCode();
                }
                if (this.Topic2 != null)
                {
                    hashCode = (hashCode * 59) + this.Topic2.GetHashCode();
                }
                if (this.Topic3 != null)
                {
                    hashCode = (hashCode * 59) + this.Topic3.GetHashCode();
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