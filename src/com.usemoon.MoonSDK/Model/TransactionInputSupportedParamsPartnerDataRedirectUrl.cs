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
    /// TransactionInputSupportedParamsPartnerDataRedirectUrl
    /// </summary>
    [DataContract(Name = "TransactionInput_supportedParams_partnerData_redirectUrl")]
    public partial class TransactionInputSupportedParamsPartnerDataRedirectUrl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInputSupportedParamsPartnerDataRedirectUrl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInputSupportedParamsPartnerDataRedirectUrl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInputSupportedParamsPartnerDataRedirectUrl" /> class.
        /// </summary>
        /// <param name="success">success (required).</param>
        public TransactionInputSupportedParamsPartnerDataRedirectUrl(string success = default(string))
        {
            // to ensure "success" is required (not null)
            if (success == null)
            {
                throw new ArgumentNullException("success is a required property for TransactionInputSupportedParamsPartnerDataRedirectUrl and cannot be null");
            }
            this.Success = success;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public string Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionInputSupportedParamsPartnerDataRedirectUrl {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
