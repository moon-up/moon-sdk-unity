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
    /// IOldNFTApproval
    /// </summary>
    [DataContract(Name = "IOldNFTApproval")]
    public partial class IOldNFTApproval : IEquatable<IOldNFTApproval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IOldNFTApproval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IOldNFTApproval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IOldNFTApproval" /> class.
        /// </summary>
        /// <param name="eRC721">eRC721 (required).</param>
        /// <param name="eRC1155">eRC1155 (required).</param>
        public IOldNFTApproval(List<INFTApprovalERC721> eRC721 = default(List<INFTApprovalERC721>), List<INFTApprovalERC1155> eRC1155 = default(List<INFTApprovalERC1155>))
        {
            // to ensure "eRC721" is required (not null)
            if (eRC721 == null)
            {
                throw new ArgumentNullException("eRC721 is a required property for IOldNFTApproval and cannot be null");
            }
            this.ERC721 = eRC721;
            // to ensure "eRC1155" is required (not null)
            if (eRC1155 == null)
            {
                throw new ArgumentNullException("eRC1155 is a required property for IOldNFTApproval and cannot be null");
            }
            this.ERC1155 = eRC1155;
        }

        /// <summary>
        /// Gets or Sets ERC721
        /// </summary>
        [DataMember(Name = "ERC721", IsRequired = true, EmitDefaultValue = true)]
        public List<INFTApprovalERC721> ERC721 { get; set; }

        /// <summary>
        /// Gets or Sets ERC1155
        /// </summary>
        [DataMember(Name = "ERC1155", IsRequired = true, EmitDefaultValue = true)]
        public List<INFTApprovalERC1155> ERC1155 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IOldNFTApproval {\n");
            sb.Append("  ERC721: ").Append(ERC721).Append("\n");
            sb.Append("  ERC1155: ").Append(ERC1155).Append("\n");
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
            return this.Equals(input as IOldNFTApproval);
        }

        /// <summary>
        /// Returns true if IOldNFTApproval instances are equal
        /// </summary>
        /// <param name="input">Instance of IOldNFTApproval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IOldNFTApproval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ERC721 == input.ERC721 ||
                    this.ERC721 != null &&
                    input.ERC721 != null &&
                    this.ERC721.SequenceEqual(input.ERC721)
                ) && 
                (
                    this.ERC1155 == input.ERC1155 ||
                    this.ERC1155 != null &&
                    input.ERC1155 != null &&
                    this.ERC1155.SequenceEqual(input.ERC1155)
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
                if (this.ERC721 != null)
                {
                    hashCode = (hashCode * 59) + this.ERC721.GetHashCode();
                }
                if (this.ERC1155 != null)
                {
                    hashCode = (hashCode * 59) + this.ERC1155.GetHashCode();
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
