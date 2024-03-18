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
    /// SupportedDefaultResponse
    /// </summary>
    [DataContract(Name = "SupportedDefaultResponse")]
    public partial class SupportedDefaultResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDefaultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedDefaultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedDefaultResponse" /> class.
        /// </summary>
        /// <param name="defaults">defaults (required).</param>
        /// <param name="recommended">recommended (required).</param>
        public SupportedDefaultResponse(SupportedDefaultResponseDefaults defaults = default(SupportedDefaultResponseDefaults), SupportedDefaultResponseDefaultsId recommended = default(SupportedDefaultResponseDefaultsId))
        {
            // to ensure "defaults" is required (not null)
            if (defaults == null)
            {
                throw new ArgumentNullException("defaults is a required property for SupportedDefaultResponse and cannot be null");
            }
            this.Defaults = defaults;
            // to ensure "recommended" is required (not null)
            if (recommended == null)
            {
                throw new ArgumentNullException("recommended is a required property for SupportedDefaultResponse and cannot be null");
            }
            this.Recommended = recommended;
        }

        /// <summary>
        /// Gets or Sets Defaults
        /// </summary>
        [DataMember(Name = "defaults", IsRequired = true, EmitDefaultValue = true)]
        public SupportedDefaultResponseDefaults Defaults { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name = "recommended", IsRequired = true, EmitDefaultValue = true)]
        public SupportedDefaultResponseDefaultsId Recommended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupportedDefaultResponse {\n");
            sb.Append("  Defaults: ").Append(Defaults).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
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
