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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TransactionInputMetaData
    /// </summary>
    [DataContract(Name = "TransactionInput_metaData")]
    public partial class TransactionInputMetaData : IEquatable<TransactionInputMetaData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInputMetaData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInputMetaData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInputMetaData" /> class.
        /// </summary>
        /// <param name="quoteId">quoteId (required).</param>
        public TransactionInputMetaData(string quoteId = default(string))
        {
            // to ensure "quoteId" is required (not null)
            if (quoteId == null)
            {
                throw new ArgumentNullException("quoteId is a required property for TransactionInputMetaData and cannot be null");
            }
            this.QuoteId = quoteId;
        }

        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name = "quoteId", IsRequired = true, EmitDefaultValue = true)]
        public string QuoteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionInputMetaData {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
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
            return this.Equals(input as TransactionInputMetaData);
        }

        /// <summary>
        /// Returns true if TransactionInputMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInputMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInputMetaData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuoteId == input.QuoteId ||
                    (this.QuoteId != null &&
                    this.QuoteId.Equals(input.QuoteId))
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
                if (this.QuoteId != null)
                {
                    hashCode = (hashCode * 59) + this.QuoteId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
