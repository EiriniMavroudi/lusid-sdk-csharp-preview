/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3504
 * Contact: info@finbourne.com
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Contains data (i.e. tenors and pips + metadata) for building fx forward curves (when combined with a spot rate and a date to build on)
    /// </summary>
    [DataContract(Name = "FxForwardTenorPipsCurveData")]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    public partial class FxForwardTenorPipsCurveData : ComplexMarketData, IEquatable<FxForwardTenorPipsCurveData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardTenorPipsCurveData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForwardTenorPipsCurveData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardTenorPipsCurveData" /> class.
        /// </summary>
        /// <param name="baseDate">EffectiveAt date of the quoted pip rates (required).</param>
        /// <param name="domCcy">Domestic currency of the fx forward (required).</param>
        /// <param name="fgnCcy">Foreign currency of the fx forward (required).</param>
        /// <param name="tenors">Tenors for which the forward rates apply (required).</param>
        /// <param name="pipRates">Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips (required).</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData (required) (default to &quot;FxForwardTenorPipsCurveData&quot;).</param>
        public FxForwardTenorPipsCurveData(DateTimeOffset baseDate = default(DateTimeOffset), string domCcy = default(string), string fgnCcy = default(string), List<string> tenors = default(List<string>), List<decimal> pipRates = default(List<decimal>), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum)) : base(marketDataType)
        {
            this.BaseDate = baseDate;
            // to ensure "domCcy" is required (not null)
            this.DomCcy = domCcy ?? throw new ArgumentNullException("domCcy is a required property for FxForwardTenorPipsCurveData and cannot be null");
            // to ensure "fgnCcy" is required (not null)
            this.FgnCcy = fgnCcy ?? throw new ArgumentNullException("fgnCcy is a required property for FxForwardTenorPipsCurveData and cannot be null");
            // to ensure "tenors" is required (not null)
            this.Tenors = tenors ?? throw new ArgumentNullException("tenors is a required property for FxForwardTenorPipsCurveData and cannot be null");
            // to ensure "pipRates" is required (not null)
            this.PipRates = pipRates ?? throw new ArgumentNullException("pipRates is a required property for FxForwardTenorPipsCurveData and cannot be null");
        }

        /// <summary>
        /// EffectiveAt date of the quoted pip rates
        /// </summary>
        /// <value>EffectiveAt date of the quoted pip rates</value>
        [DataMember(Name = "baseDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset BaseDate { get; set; }

        /// <summary>
        /// Domestic currency of the fx forward
        /// </summary>
        /// <value>Domestic currency of the fx forward</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// Foreign currency of the fx forward
        /// </summary>
        /// <value>Foreign currency of the fx forward</value>
        [DataMember(Name = "fgnCcy", IsRequired = true, EmitDefaultValue = false)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// Tenors for which the forward rates apply
        /// </summary>
        /// <value>Tenors for which the forward rates apply</value>
        [DataMember(Name = "tenors", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Tenors { get; set; }

        /// <summary>
        /// Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips
        /// </summary>
        /// <value>Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips</value>
        [DataMember(Name = "pipRates", IsRequired = true, EmitDefaultValue = false)]
        public List<decimal> PipRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FxForwardTenorPipsCurveData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  Tenors: ").Append(Tenors).Append("\n");
            sb.Append("  PipRates: ").Append(PipRates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FxForwardTenorPipsCurveData);
        }

        /// <summary>
        /// Returns true if FxForwardTenorPipsCurveData instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForwardTenorPipsCurveData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForwardTenorPipsCurveData input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BaseDate == input.BaseDate ||
                    (this.BaseDate != null &&
                    this.BaseDate.Equals(input.BaseDate))
                ) && base.Equals(input) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && base.Equals(input) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && base.Equals(input) && 
                (
                    this.Tenors == input.Tenors ||
                    this.Tenors != null &&
                    input.Tenors != null &&
                    this.Tenors.SequenceEqual(input.Tenors)
                ) && base.Equals(input) && 
                (
                    this.PipRates == input.PipRates ||
                    this.PipRates != null &&
                    input.PipRates != null &&
                    this.PipRates.SequenceEqual(input.PipRates)
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
                int hashCode = base.GetHashCode();
                if (this.BaseDate != null)
                    hashCode = hashCode * 59 + this.BaseDate.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                if (this.FgnCcy != null)
                    hashCode = hashCode * 59 + this.FgnCcy.GetHashCode();
                if (this.Tenors != null)
                    hashCode = hashCode * 59 + this.Tenors.GetHashCode();
                if (this.PipRates != null)
                    hashCode = hashCode * 59 + this.PipRates.GetHashCode();
                return hashCode;
            }
        }

    }
}