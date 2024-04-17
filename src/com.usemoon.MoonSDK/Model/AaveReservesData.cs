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
    /// AaveReservesData
    /// </summary>
    [DataContract(Name = "AaveReservesData")]
    public partial class AaveReservesData : IEquatable<AaveReservesData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AaveReservesData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AaveReservesData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AaveReservesData" /> class.
        /// </summary>
        /// <param name="currentAtokenBalance">currentAtokenBalance (required).</param>
        /// <param name="currentBorrowBalance">currentBorrowBalance (required).</param>
        /// <param name="principalBorrowBalance">principalBorrowBalance (required).</param>
        /// <param name="borrowRateMode">borrowRateMode (required).</param>
        /// <param name="borrowRate">borrowRate (required).</param>
        /// <param name="liquidityRate">liquidityRate (required).</param>
        /// <param name="originationFee">originationFee (required).</param>
        /// <param name="variableBorrowIndex">variableBorrowIndex (required).</param>
        /// <param name="lastUpdateTimestamp">lastUpdateTimestamp (required).</param>
        /// <param name="usageAsCollateralEnabled">usageAsCollateralEnabled (required).</param>
        public AaveReservesData(string currentAtokenBalance = default(string), string currentBorrowBalance = default(string), string principalBorrowBalance = default(string), string borrowRateMode = default(string), string borrowRate = default(string), string liquidityRate = default(string), string originationFee = default(string), string variableBorrowIndex = default(string), string lastUpdateTimestamp = default(string), string usageAsCollateralEnabled = default(string))
        {
            // to ensure "currentAtokenBalance" is required (not null)
            if (currentAtokenBalance == null)
            {
                throw new ArgumentNullException("currentAtokenBalance is a required property for AaveReservesData and cannot be null");
            }
            this.CurrentAtokenBalance = currentAtokenBalance;
            // to ensure "currentBorrowBalance" is required (not null)
            if (currentBorrowBalance == null)
            {
                throw new ArgumentNullException("currentBorrowBalance is a required property for AaveReservesData and cannot be null");
            }
            this.CurrentBorrowBalance = currentBorrowBalance;
            // to ensure "principalBorrowBalance" is required (not null)
            if (principalBorrowBalance == null)
            {
                throw new ArgumentNullException("principalBorrowBalance is a required property for AaveReservesData and cannot be null");
            }
            this.PrincipalBorrowBalance = principalBorrowBalance;
            // to ensure "borrowRateMode" is required (not null)
            if (borrowRateMode == null)
            {
                throw new ArgumentNullException("borrowRateMode is a required property for AaveReservesData and cannot be null");
            }
            this.BorrowRateMode = borrowRateMode;
            // to ensure "borrowRate" is required (not null)
            if (borrowRate == null)
            {
                throw new ArgumentNullException("borrowRate is a required property for AaveReservesData and cannot be null");
            }
            this.BorrowRate = borrowRate;
            // to ensure "liquidityRate" is required (not null)
            if (liquidityRate == null)
            {
                throw new ArgumentNullException("liquidityRate is a required property for AaveReservesData and cannot be null");
            }
            this.LiquidityRate = liquidityRate;
            // to ensure "originationFee" is required (not null)
            if (originationFee == null)
            {
                throw new ArgumentNullException("originationFee is a required property for AaveReservesData and cannot be null");
            }
            this.OriginationFee = originationFee;
            // to ensure "variableBorrowIndex" is required (not null)
            if (variableBorrowIndex == null)
            {
                throw new ArgumentNullException("variableBorrowIndex is a required property for AaveReservesData and cannot be null");
            }
            this.VariableBorrowIndex = variableBorrowIndex;
            // to ensure "lastUpdateTimestamp" is required (not null)
            if (lastUpdateTimestamp == null)
            {
                throw new ArgumentNullException("lastUpdateTimestamp is a required property for AaveReservesData and cannot be null");
            }
            this.LastUpdateTimestamp = lastUpdateTimestamp;
            // to ensure "usageAsCollateralEnabled" is required (not null)
            if (usageAsCollateralEnabled == null)
            {
                throw new ArgumentNullException("usageAsCollateralEnabled is a required property for AaveReservesData and cannot be null");
            }
            this.UsageAsCollateralEnabled = usageAsCollateralEnabled;
        }

        /// <summary>
        /// Gets or Sets CurrentAtokenBalance
        /// </summary>
        [DataMember(Name = "current_atoken_balance", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentAtokenBalance { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBorrowBalance
        /// </summary>
        [DataMember(Name = "current_borrow_balance", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentBorrowBalance { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalBorrowBalance
        /// </summary>
        [DataMember(Name = "principal_borrow_balance", IsRequired = true, EmitDefaultValue = true)]
        public string PrincipalBorrowBalance { get; set; }

        /// <summary>
        /// Gets or Sets BorrowRateMode
        /// </summary>
        [DataMember(Name = "borrow_rate_mode", IsRequired = true, EmitDefaultValue = true)]
        public string BorrowRateMode { get; set; }

        /// <summary>
        /// Gets or Sets BorrowRate
        /// </summary>
        [DataMember(Name = "borrow_rate", IsRequired = true, EmitDefaultValue = true)]
        public string BorrowRate { get; set; }

        /// <summary>
        /// Gets or Sets LiquidityRate
        /// </summary>
        [DataMember(Name = "liquidity_rate", IsRequired = true, EmitDefaultValue = true)]
        public string LiquidityRate { get; set; }

        /// <summary>
        /// Gets or Sets OriginationFee
        /// </summary>
        [DataMember(Name = "origination_fee", IsRequired = true, EmitDefaultValue = true)]
        public string OriginationFee { get; set; }

        /// <summary>
        /// Gets or Sets VariableBorrowIndex
        /// </summary>
        [DataMember(Name = "variable_borrow_index", IsRequired = true, EmitDefaultValue = true)]
        public string VariableBorrowIndex { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateTimestamp
        /// </summary>
        [DataMember(Name = "last_update_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets UsageAsCollateralEnabled
        /// </summary>
        [DataMember(Name = "usage_as_collateral_enabled", IsRequired = true, EmitDefaultValue = true)]
        public string UsageAsCollateralEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AaveReservesData {\n");
            sb.Append("  CurrentAtokenBalance: ").Append(CurrentAtokenBalance).Append("\n");
            sb.Append("  CurrentBorrowBalance: ").Append(CurrentBorrowBalance).Append("\n");
            sb.Append("  PrincipalBorrowBalance: ").Append(PrincipalBorrowBalance).Append("\n");
            sb.Append("  BorrowRateMode: ").Append(BorrowRateMode).Append("\n");
            sb.Append("  BorrowRate: ").Append(BorrowRate).Append("\n");
            sb.Append("  LiquidityRate: ").Append(LiquidityRate).Append("\n");
            sb.Append("  OriginationFee: ").Append(OriginationFee).Append("\n");
            sb.Append("  VariableBorrowIndex: ").Append(VariableBorrowIndex).Append("\n");
            sb.Append("  LastUpdateTimestamp: ").Append(LastUpdateTimestamp).Append("\n");
            sb.Append("  UsageAsCollateralEnabled: ").Append(UsageAsCollateralEnabled).Append("\n");
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
            return this.Equals(input as AaveReservesData);
        }

        /// <summary>
        /// Returns true if AaveReservesData instances are equal
        /// </summary>
        /// <param name="input">Instance of AaveReservesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AaveReservesData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentAtokenBalance == input.CurrentAtokenBalance ||
                    (this.CurrentAtokenBalance != null &&
                    this.CurrentAtokenBalance.Equals(input.CurrentAtokenBalance))
                ) && 
                (
                    this.CurrentBorrowBalance == input.CurrentBorrowBalance ||
                    (this.CurrentBorrowBalance != null &&
                    this.CurrentBorrowBalance.Equals(input.CurrentBorrowBalance))
                ) && 
                (
                    this.PrincipalBorrowBalance == input.PrincipalBorrowBalance ||
                    (this.PrincipalBorrowBalance != null &&
                    this.PrincipalBorrowBalance.Equals(input.PrincipalBorrowBalance))
                ) && 
                (
                    this.BorrowRateMode == input.BorrowRateMode ||
                    (this.BorrowRateMode != null &&
                    this.BorrowRateMode.Equals(input.BorrowRateMode))
                ) && 
                (
                    this.BorrowRate == input.BorrowRate ||
                    (this.BorrowRate != null &&
                    this.BorrowRate.Equals(input.BorrowRate))
                ) && 
                (
                    this.LiquidityRate == input.LiquidityRate ||
                    (this.LiquidityRate != null &&
                    this.LiquidityRate.Equals(input.LiquidityRate))
                ) && 
                (
                    this.OriginationFee == input.OriginationFee ||
                    (this.OriginationFee != null &&
                    this.OriginationFee.Equals(input.OriginationFee))
                ) && 
                (
                    this.VariableBorrowIndex == input.VariableBorrowIndex ||
                    (this.VariableBorrowIndex != null &&
                    this.VariableBorrowIndex.Equals(input.VariableBorrowIndex))
                ) && 
                (
                    this.LastUpdateTimestamp == input.LastUpdateTimestamp ||
                    (this.LastUpdateTimestamp != null &&
                    this.LastUpdateTimestamp.Equals(input.LastUpdateTimestamp))
                ) && 
                (
                    this.UsageAsCollateralEnabled == input.UsageAsCollateralEnabled ||
                    (this.UsageAsCollateralEnabled != null &&
                    this.UsageAsCollateralEnabled.Equals(input.UsageAsCollateralEnabled))
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
                if (this.CurrentAtokenBalance != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAtokenBalance.GetHashCode();
                }
                if (this.CurrentBorrowBalance != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentBorrowBalance.GetHashCode();
                }
                if (this.PrincipalBorrowBalance != null)
                {
                    hashCode = (hashCode * 59) + this.PrincipalBorrowBalance.GetHashCode();
                }
                if (this.BorrowRateMode != null)
                {
                    hashCode = (hashCode * 59) + this.BorrowRateMode.GetHashCode();
                }
                if (this.BorrowRate != null)
                {
                    hashCode = (hashCode * 59) + this.BorrowRate.GetHashCode();
                }
                if (this.LiquidityRate != null)
                {
                    hashCode = (hashCode * 59) + this.LiquidityRate.GetHashCode();
                }
                if (this.OriginationFee != null)
                {
                    hashCode = (hashCode * 59) + this.OriginationFee.GetHashCode();
                }
                if (this.VariableBorrowIndex != null)
                {
                    hashCode = (hashCode * 59) + this.VariableBorrowIndex.GetHashCode();
                }
                if (this.LastUpdateTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdateTimestamp.GetHashCode();
                }
                if (this.UsageAsCollateralEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.UsageAsCollateralEnabled.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
