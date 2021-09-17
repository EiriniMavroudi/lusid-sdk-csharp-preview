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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// external market codes and identifiers for the equity, e.g. IBM
    /// </summary>
    [DataContract(Name = "Equity_allOf_identifiers")]
    public partial class EquityAllOfIdentifiers : IEquatable<EquityAllOfIdentifiers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityAllOfIdentifiers" /> class.
        /// </summary>
        /// <param name="lusidInstrumentId">lusidInstrumentId.</param>
        /// <param name="isin">isin.</param>
        /// <param name="sedol">sedol.</param>
        /// <param name="cusip">cusip.</param>
        /// <param name="clientInternal">clientInternal.</param>
        /// <param name="figi">figi.</param>
        /// <param name="rIC">rIC.</param>
        /// <param name="quotePermId">quotePermId.</param>
        /// <param name="rEDCode">rEDCode.</param>
        /// <param name="bBGId">bBGId.</param>
        /// <param name="iCECode">iCECode.</param>
        public EquityAllOfIdentifiers(string lusidInstrumentId = default(string), string isin = default(string), string sedol = default(string), string cusip = default(string), string clientInternal = default(string), string figi = default(string), string rIC = default(string), string quotePermId = default(string), string rEDCode = default(string), string bBGId = default(string), string iCECode = default(string))
        {
            this.LusidInstrumentId = lusidInstrumentId;
            this.Isin = isin;
            this.Sedol = sedol;
            this.Cusip = cusip;
            this.ClientInternal = clientInternal;
            this.Figi = figi;
            this.RIC = rIC;
            this.QuotePermId = quotePermId;
            this.REDCode = rEDCode;
            this.BBGId = bBGId;
            this.ICECode = iCECode;
        }

        /// <summary>
        /// Gets or Sets LusidInstrumentId
        /// </summary>
        [DataMember(Name = "LusidInstrumentId", EmitDefaultValue = false)]
        public string LusidInstrumentId { get; set; }

        /// <summary>
        /// Gets or Sets Isin
        /// </summary>
        [DataMember(Name = "Isin", EmitDefaultValue = false)]
        public string Isin { get; set; }

        /// <summary>
        /// Gets or Sets Sedol
        /// </summary>
        [DataMember(Name = "Sedol", EmitDefaultValue = false)]
        public string Sedol { get; set; }

        /// <summary>
        /// Gets or Sets Cusip
        /// </summary>
        [DataMember(Name = "Cusip", EmitDefaultValue = false)]
        public string Cusip { get; set; }

        /// <summary>
        /// Gets or Sets ClientInternal
        /// </summary>
        [DataMember(Name = "ClientInternal", EmitDefaultValue = false)]
        public string ClientInternal { get; set; }

        /// <summary>
        /// Gets or Sets Figi
        /// </summary>
        [DataMember(Name = "Figi", EmitDefaultValue = false)]
        public string Figi { get; set; }

        /// <summary>
        /// Gets or Sets RIC
        /// </summary>
        [DataMember(Name = "RIC", EmitDefaultValue = false)]
        public string RIC { get; set; }

        /// <summary>
        /// Gets or Sets QuotePermId
        /// </summary>
        [DataMember(Name = "QuotePermId", EmitDefaultValue = false)]
        public string QuotePermId { get; set; }

        /// <summary>
        /// Gets or Sets REDCode
        /// </summary>
        [DataMember(Name = "REDCode", EmitDefaultValue = false)]
        public string REDCode { get; set; }

        /// <summary>
        /// Gets or Sets BBGId
        /// </summary>
        [DataMember(Name = "BBGId", EmitDefaultValue = false)]
        public string BBGId { get; set; }

        /// <summary>
        /// Gets or Sets ICECode
        /// </summary>
        [DataMember(Name = "ICECode", EmitDefaultValue = false)]
        public string ICECode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EquityAllOfIdentifiers {\n");
            sb.Append("  LusidInstrumentId: ").Append(LusidInstrumentId).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  Sedol: ").Append(Sedol).Append("\n");
            sb.Append("  Cusip: ").Append(Cusip).Append("\n");
            sb.Append("  ClientInternal: ").Append(ClientInternal).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  RIC: ").Append(RIC).Append("\n");
            sb.Append("  QuotePermId: ").Append(QuotePermId).Append("\n");
            sb.Append("  REDCode: ").Append(REDCode).Append("\n");
            sb.Append("  BBGId: ").Append(BBGId).Append("\n");
            sb.Append("  ICECode: ").Append(ICECode).Append("\n");
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
            return this.Equals(input as EquityAllOfIdentifiers);
        }

        /// <summary>
        /// Returns true if EquityAllOfIdentifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of EquityAllOfIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EquityAllOfIdentifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LusidInstrumentId == input.LusidInstrumentId ||
                    (this.LusidInstrumentId != null &&
                    this.LusidInstrumentId.Equals(input.LusidInstrumentId))
                ) && 
                (
                    this.Isin == input.Isin ||
                    (this.Isin != null &&
                    this.Isin.Equals(input.Isin))
                ) && 
                (
                    this.Sedol == input.Sedol ||
                    (this.Sedol != null &&
                    this.Sedol.Equals(input.Sedol))
                ) && 
                (
                    this.Cusip == input.Cusip ||
                    (this.Cusip != null &&
                    this.Cusip.Equals(input.Cusip))
                ) && 
                (
                    this.ClientInternal == input.ClientInternal ||
                    (this.ClientInternal != null &&
                    this.ClientInternal.Equals(input.ClientInternal))
                ) && 
                (
                    this.Figi == input.Figi ||
                    (this.Figi != null &&
                    this.Figi.Equals(input.Figi))
                ) && 
                (
                    this.RIC == input.RIC ||
                    (this.RIC != null &&
                    this.RIC.Equals(input.RIC))
                ) && 
                (
                    this.QuotePermId == input.QuotePermId ||
                    (this.QuotePermId != null &&
                    this.QuotePermId.Equals(input.QuotePermId))
                ) && 
                (
                    this.REDCode == input.REDCode ||
                    (this.REDCode != null &&
                    this.REDCode.Equals(input.REDCode))
                ) && 
                (
                    this.BBGId == input.BBGId ||
                    (this.BBGId != null &&
                    this.BBGId.Equals(input.BBGId))
                ) && 
                (
                    this.ICECode == input.ICECode ||
                    (this.ICECode != null &&
                    this.ICECode.Equals(input.ICECode))
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
                if (this.LusidInstrumentId != null)
                    hashCode = hashCode * 59 + this.LusidInstrumentId.GetHashCode();
                if (this.Isin != null)
                    hashCode = hashCode * 59 + this.Isin.GetHashCode();
                if (this.Sedol != null)
                    hashCode = hashCode * 59 + this.Sedol.GetHashCode();
                if (this.Cusip != null)
                    hashCode = hashCode * 59 + this.Cusip.GetHashCode();
                if (this.ClientInternal != null)
                    hashCode = hashCode * 59 + this.ClientInternal.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.RIC != null)
                    hashCode = hashCode * 59 + this.RIC.GetHashCode();
                if (this.QuotePermId != null)
                    hashCode = hashCode * 59 + this.QuotePermId.GetHashCode();
                if (this.REDCode != null)
                    hashCode = hashCode * 59 + this.REDCode.GetHashCode();
                if (this.BBGId != null)
                    hashCode = hashCode * 59 + this.BBGId.GetHashCode();
                if (this.ICECode != null)
                    hashCode = hashCode * 59 + this.ICECode.GetHashCode();
                return hashCode;
            }
        }

    }
}