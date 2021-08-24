/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3421
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// OpaqueMarketDataAllOf
    /// </summary>
    [DataContract]
    public partial class OpaqueMarketDataAllOf :  IEquatable<OpaqueMarketDataAllOf>
    {
        /// <summary>
        /// The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData
        /// </summary>
        /// <value>The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarketDataTypeEnum
        {
            /// <summary>
            /// Enum DiscountFactorCurveData for value: DiscountFactorCurveData
            /// </summary>
            [EnumMember(Value = "DiscountFactorCurveData")]
            DiscountFactorCurveData = 1,

            /// <summary>
            /// Enum EquityVolSurfaceData for value: EquityVolSurfaceData
            /// </summary>
            [EnumMember(Value = "EquityVolSurfaceData")]
            EquityVolSurfaceData = 2,

            /// <summary>
            /// Enum FxVolSurfaceData for value: FxVolSurfaceData
            /// </summary>
            [EnumMember(Value = "FxVolSurfaceData")]
            FxVolSurfaceData = 3,

            /// <summary>
            /// Enum IrVolCubeData for value: IrVolCubeData
            /// </summary>
            [EnumMember(Value = "IrVolCubeData")]
            IrVolCubeData = 4,

            /// <summary>
            /// Enum OpaqueMarketData for value: OpaqueMarketData
            /// </summary>
            [EnumMember(Value = "OpaqueMarketData")]
            OpaqueMarketData = 5,

            /// <summary>
            /// Enum YieldCurveData for value: YieldCurveData
            /// </summary>
            [EnumMember(Value = "YieldCurveData")]
            YieldCurveData = 6

        }

        /// <summary>
        /// The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData
        /// </summary>
        /// <value>The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData</value>
        [DataMember(Name="marketDataType", EmitDefaultValue=false)]
        public MarketDataTypeEnum MarketDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueMarketDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpaqueMarketDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueMarketDataAllOf" /> class.
        /// </summary>
        /// <param name="document">The document as a string. (required).</param>
        /// <param name="format">What format is the document stored in, e.g. Xml.  Supported string (enumeration) values are: [Unknown, Xml, Json, Csv]. (required).</param>
        /// <param name="name">Internal name of document. This is not used for search, it is simply a designator that helps identify the document  and could be anything (filename, ftp address or similar) (required).</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData (required).</param>
        public OpaqueMarketDataAllOf(string document = default(string), string format = default(string), string name = default(string), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum))
        {
            // to ensure "document" is required (not null)
            if (document == null)
            {
                throw new InvalidDataException("document is a required property for OpaqueMarketDataAllOf and cannot be null");
            }
            else
            {
                this.Document = document;
            }
            
            // to ensure "format" is required (not null)
            if (format == null)
            {
                throw new InvalidDataException("format is a required property for OpaqueMarketDataAllOf and cannot be null");
            }
            else
            {
                this.Format = format;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for OpaqueMarketDataAllOf and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "marketDataType" is required (not null)
            if (marketDataType == null)
            {
                throw new InvalidDataException("marketDataType is a required property for OpaqueMarketDataAllOf and cannot be null");
            }
            else
            {
                this.MarketDataType = marketDataType;
            }
            
        }
        
        /// <summary>
        /// The document as a string.
        /// </summary>
        /// <value>The document as a string.</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public string Document { get; set; }

        /// <summary>
        /// What format is the document stored in, e.g. Xml.  Supported string (enumeration) values are: [Unknown, Xml, Json, Csv].
        /// </summary>
        /// <value>What format is the document stored in, e.g. Xml.  Supported string (enumeration) values are: [Unknown, Xml, Json, Csv].</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Internal name of document. This is not used for search, it is simply a designator that helps identify the document  and could be anything (filename, ftp address or similar)
        /// </summary>
        /// <value>Internal name of document. This is not used for search, it is simply a designator that helps identify the document  and could be anything (filename, ftp address or similar)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpaqueMarketDataAllOf {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MarketDataType: ").Append(MarketDataType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpaqueMarketDataAllOf);
        }

        /// <summary>
        /// Returns true if OpaqueMarketDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of OpaqueMarketDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpaqueMarketDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MarketDataType == input.MarketDataType ||
                    (this.MarketDataType != null &&
                    this.MarketDataType.Equals(input.MarketDataType))
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
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MarketDataType != null)
                    hashCode = hashCode * 59 + this.MarketDataType.GetHashCode();
                return hashCode;
            }
        }
    }

}
