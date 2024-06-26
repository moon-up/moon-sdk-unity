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
    /// FiatCurrency
    /// </summary>
    [DataContract(Name = "FiatCurrency")]
    public partial class FiatCurrency : IEquatable<FiatCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FiatCurrency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FiatCurrency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FiatCurrency" /> class.
        /// </summary>
        /// <param name="icon">icon (required).</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="id">id (required).</param>
        public FiatCurrency(string icon = default(string), string symbol = default(string), string name = default(string), string code = default(string), string id = default(string))
        {
            // to ensure "icon" is required (not null)
            if (icon == null)
            {
                throw new ArgumentNullException("icon is a required property for FiatCurrency and cannot be null");
            }
            this.Icon = icon;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for FiatCurrency and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FiatCurrency and cannot be null");
            }
            this.Name = name;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for FiatCurrency and cannot be null");
            }
            this.Code = code;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FiatCurrency and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", IsRequired = true, EmitDefaultValue = true)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FiatCurrency {\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as FiatCurrency);
        }

        /// <summary>
        /// Returns true if FiatCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of FiatCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FiatCurrency input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
