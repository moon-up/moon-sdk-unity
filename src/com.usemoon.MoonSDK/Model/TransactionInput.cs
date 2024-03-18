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
    /// TransactionInput
    /// </summary>
    [DataContract(Name = "TransactionInput")]
    public partial class TransactionInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInput" /> class.
        /// </summary>
        /// <param name="supportedParams">supportedParams (required).</param>
        /// <param name="wallet">wallet (required).</param>
        /// <param name="metaData">metaData (required).</param>
        /// <param name="originatingHost">originatingHost (required).</param>
        /// <param name="partnerContext">partnerContext (required).</param>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="destination">destination (required).</param>
        /// <param name="source">source (required).</param>
        /// <param name="onramp">onramp (required).</param>
        public TransactionInput(TransactionInputSupportedParams supportedParams = default(TransactionInputSupportedParams), TransactionInputWallet wallet = default(TransactionInputWallet), TransactionInputMetaData metaData = default(TransactionInputMetaData), string originatingHost = default(string), string partnerContext = default(string), string uuid = default(string), string network = default(string), string paymentMethod = default(string), string type = default(string), double amount = default(double), string destination = default(string), string source = default(string), string onramp = default(string))
        {
            // to ensure "supportedParams" is required (not null)
            if (supportedParams == null)
            {
                throw new ArgumentNullException("supportedParams is a required property for TransactionInput and cannot be null");
            }
            this.SupportedParams = supportedParams;
            // to ensure "wallet" is required (not null)
            if (wallet == null)
            {
                throw new ArgumentNullException("wallet is a required property for TransactionInput and cannot be null");
            }
            this.Wallet = wallet;
            // to ensure "metaData" is required (not null)
            if (metaData == null)
            {
                throw new ArgumentNullException("metaData is a required property for TransactionInput and cannot be null");
            }
            this.MetaData = metaData;
            // to ensure "originatingHost" is required (not null)
            if (originatingHost == null)
            {
                throw new ArgumentNullException("originatingHost is a required property for TransactionInput and cannot be null");
            }
            this.OriginatingHost = originatingHost;
            // to ensure "partnerContext" is required (not null)
            if (partnerContext == null)
            {
                throw new ArgumentNullException("partnerContext is a required property for TransactionInput and cannot be null");
            }
            this.PartnerContext = partnerContext;
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for TransactionInput and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for TransactionInput and cannot be null");
            }
            this.Network = network;
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for TransactionInput and cannot be null");
            }
            this.PaymentMethod = paymentMethod;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for TransactionInput and cannot be null");
            }
            this.Type = type;
            this.Amount = amount;
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new ArgumentNullException("destination is a required property for TransactionInput and cannot be null");
            }
            this.Destination = destination;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for TransactionInput and cannot be null");
            }
            this.Source = source;
            // to ensure "onramp" is required (not null)
            if (onramp == null)
            {
                throw new ArgumentNullException("onramp is a required property for TransactionInput and cannot be null");
            }
            this.Onramp = onramp;
        }

        /// <summary>
        /// Gets or Sets SupportedParams
        /// </summary>
        [DataMember(Name = "supportedParams", IsRequired = true, EmitDefaultValue = true)]
        public TransactionInputSupportedParams SupportedParams { get; set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name = "wallet", IsRequired = true, EmitDefaultValue = true)]
        public TransactionInputWallet Wallet { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "metaData", IsRequired = true, EmitDefaultValue = true)]
        public TransactionInputMetaData MetaData { get; set; }

        /// <summary>
        /// Gets or Sets OriginatingHost
        /// </summary>
        [DataMember(Name = "originatingHost", IsRequired = true, EmitDefaultValue = true)]
        public string OriginatingHost { get; set; }

        /// <summary>
        /// Gets or Sets PartnerContext
        /// </summary>
        [DataMember(Name = "partnerContext", IsRequired = true, EmitDefaultValue = true)]
        public string PartnerContext { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = true)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", IsRequired = true, EmitDefaultValue = true)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Onramp
        /// </summary>
        [DataMember(Name = "onramp", IsRequired = true, EmitDefaultValue = true)]
        public string Onramp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionInput {\n");
            sb.Append("  SupportedParams: ").Append(SupportedParams).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  OriginatingHost: ").Append(OriginatingHost).Append("\n");
            sb.Append("  PartnerContext: ").Append(PartnerContext).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Onramp: ").Append(Onramp).Append("\n");
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
