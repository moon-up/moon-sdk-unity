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
    /// AbiOutput
    /// </summary>
    [DataContract(Name = "AbiOutput")]
    public partial class AbiOutput : IEquatable<AbiOutput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbiOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbiOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbiOutput" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="components">components.</param>
        /// <param name="internalType">internalType.</param>
        public AbiOutput(string name = default(string), string type = default(string), List<AbiOutput> components = default(List<AbiOutput>), string internalType = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AbiOutput and cannot be null");
            }
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AbiOutput and cannot be null");
            }
            this.Type = type;
            this.Components = components;
            this.InternalType = internalType;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        public List<AbiOutput> Components { get; set; }

        /// <summary>
        /// Gets or Sets InternalType
        /// </summary>
        [DataMember(Name = "internalType", EmitDefaultValue = false)]
        public string InternalType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbiOutput {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  InternalType: ").Append(InternalType).Append("\n");
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
            return this.Equals(input as AbiOutput);
        }

        /// <summary>
        /// Returns true if AbiOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of AbiOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbiOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    input.Components != null &&
                    this.Components.SequenceEqual(input.Components)
                ) && 
                (
                    this.InternalType == input.InternalType ||
                    (this.InternalType != null &&
                    this.InternalType.Equals(input.InternalType))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
                }
                if (this.InternalType != null)
                {
                    hashCode = (hashCode * 59) + this.InternalType.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
