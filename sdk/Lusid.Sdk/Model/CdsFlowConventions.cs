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
    /// CdsFlowConventions
    /// </summary>
    [DataContract]
    public partial class CdsFlowConventions :  IEquatable<CdsFlowConventions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsFlowConventions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CdsFlowConventions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsFlowConventions" /> class.
        /// </summary>
        /// <param name="rollFrequency">The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products.</param>
        /// <param name="currency">Currency of the flow convention. (required).</param>
        /// <param name="paymentFrequency">When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment. (required).</param>
        /// <param name="dayCountConvention">when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActAct, ActualActual, ActActIsda, ActActIsma, ActActIcma]. (required).</param>
        /// <param name="rollConvention">When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.  Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, EndOfMonth, EOM, EndOfMonthPrevious, EOMP, EndOfMonthFollowing, EOMF]. (required).</param>
        /// <param name="paymentCalendars">An array of strings denoting holiday calendars that apply to generation of payment schedules. (required).</param>
        /// <param name="resetCalendars">An array of strings denoting holiday calendars that apply to generation of reset schedules. (required).</param>
        /// <param name="settleDays">Number of Good Business Days between the trade date and the effective or settlement date of the instrument. (required).</param>
        /// <param name="resetDays">The number of Good Business Days between determination and payment of reset. (required).</param>
        /// <param name="scope">The scope used when updating or inserting the convention..</param>
        /// <param name="code">The code of the convention..</param>
        public CdsFlowConventions(string rollFrequency = default(string), string currency = default(string), string paymentFrequency = default(string), string dayCountConvention = default(string), string rollConvention = default(string), List<string> paymentCalendars = default(List<string>), List<string> resetCalendars = default(List<string>), int? settleDays = default(int?), int? resetDays = default(int?), string scope = default(string), string code = default(string))
        {
            this.RollFrequency = rollFrequency;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "paymentFrequency" is required (not null)
            if (paymentFrequency == null)
            {
                throw new InvalidDataException("paymentFrequency is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.PaymentFrequency = paymentFrequency;
            }
            
            // to ensure "dayCountConvention" is required (not null)
            if (dayCountConvention == null)
            {
                throw new InvalidDataException("dayCountConvention is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.DayCountConvention = dayCountConvention;
            }
            
            // to ensure "rollConvention" is required (not null)
            if (rollConvention == null)
            {
                throw new InvalidDataException("rollConvention is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.RollConvention = rollConvention;
            }
            
            // to ensure "paymentCalendars" is required (not null)
            if (paymentCalendars == null)
            {
                throw new InvalidDataException("paymentCalendars is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.PaymentCalendars = paymentCalendars;
            }
            
            // to ensure "resetCalendars" is required (not null)
            if (resetCalendars == null)
            {
                throw new InvalidDataException("resetCalendars is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.ResetCalendars = resetCalendars;
            }
            
            // to ensure "settleDays" is required (not null)
            if (settleDays == null)
            {
                throw new InvalidDataException("settleDays is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.SettleDays = settleDays;
            }
            
            // to ensure "resetDays" is required (not null)
            if (resetDays == null)
            {
                throw new InvalidDataException("resetDays is a required property for CdsFlowConventions and cannot be null");
            }
            else
            {
                this.ResetDays = resetDays;
            }
            
            this.Scope = scope;
            this.Code = code;
            this.RollFrequency = rollFrequency;
            this.Scope = scope;
            this.Code = code;
        }
        
        /// <summary>
        /// The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products
        /// </summary>
        /// <value>The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products</value>
        [DataMember(Name="rollFrequency", EmitDefaultValue=true)]
        public string RollFrequency { get; set; }

        /// <summary>
        /// Currency of the flow convention.
        /// </summary>
        /// <value>Currency of the flow convention.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment.
        /// </summary>
        /// <value>When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment.</value>
        [DataMember(Name="paymentFrequency", EmitDefaultValue=false)]
        public string PaymentFrequency { get; set; }

        /// <summary>
        /// when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActAct, ActualActual, ActActIsda, ActActIsma, ActActIcma].
        /// </summary>
        /// <value>when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActAct, ActualActual, ActActIsda, ActActIsma, ActActIcma].</value>
        [DataMember(Name="dayCountConvention", EmitDefaultValue=false)]
        public string DayCountConvention { get; set; }

        /// <summary>
        /// When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.  Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, EndOfMonth, EOM, EndOfMonthPrevious, EOMP, EndOfMonthFollowing, EOMF].
        /// </summary>
        /// <value>When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.  Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, EndOfMonth, EOM, EndOfMonthPrevious, EOMP, EndOfMonthFollowing, EOMF].</value>
        [DataMember(Name="rollConvention", EmitDefaultValue=false)]
        public string RollConvention { get; set; }

        /// <summary>
        /// An array of strings denoting holiday calendars that apply to generation of payment schedules.
        /// </summary>
        /// <value>An array of strings denoting holiday calendars that apply to generation of payment schedules.</value>
        [DataMember(Name="paymentCalendars", EmitDefaultValue=false)]
        public List<string> PaymentCalendars { get; set; }

        /// <summary>
        /// An array of strings denoting holiday calendars that apply to generation of reset schedules.
        /// </summary>
        /// <value>An array of strings denoting holiday calendars that apply to generation of reset schedules.</value>
        [DataMember(Name="resetCalendars", EmitDefaultValue=false)]
        public List<string> ResetCalendars { get; set; }

        /// <summary>
        /// Number of Good Business Days between the trade date and the effective or settlement date of the instrument.
        /// </summary>
        /// <value>Number of Good Business Days between the trade date and the effective or settlement date of the instrument.</value>
        [DataMember(Name="settleDays", EmitDefaultValue=false)]
        public int? SettleDays { get; set; }

        /// <summary>
        /// The number of Good Business Days between determination and payment of reset.
        /// </summary>
        /// <value>The number of Good Business Days between determination and payment of reset.</value>
        [DataMember(Name="resetDays", EmitDefaultValue=false)]
        public int? ResetDays { get; set; }

        /// <summary>
        /// The scope used when updating or inserting the convention.
        /// </summary>
        /// <value>The scope used when updating or inserting the convention.</value>
        [DataMember(Name="scope", EmitDefaultValue=true)]
        public string Scope { get; set; }

        /// <summary>
        /// The code of the convention.
        /// </summary>
        /// <value>The code of the convention.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CdsFlowConventions {\n");
            sb.Append("  RollFrequency: ").Append(RollFrequency).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentFrequency: ").Append(PaymentFrequency).Append("\n");
            sb.Append("  DayCountConvention: ").Append(DayCountConvention).Append("\n");
            sb.Append("  RollConvention: ").Append(RollConvention).Append("\n");
            sb.Append("  PaymentCalendars: ").Append(PaymentCalendars).Append("\n");
            sb.Append("  ResetCalendars: ").Append(ResetCalendars).Append("\n");
            sb.Append("  SettleDays: ").Append(SettleDays).Append("\n");
            sb.Append("  ResetDays: ").Append(ResetDays).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as CdsFlowConventions);
        }

        /// <summary>
        /// Returns true if CdsFlowConventions instances are equal
        /// </summary>
        /// <param name="input">Instance of CdsFlowConventions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdsFlowConventions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RollFrequency == input.RollFrequency ||
                    (this.RollFrequency != null &&
                    this.RollFrequency.Equals(input.RollFrequency))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaymentFrequency == input.PaymentFrequency ||
                    (this.PaymentFrequency != null &&
                    this.PaymentFrequency.Equals(input.PaymentFrequency))
                ) && 
                (
                    this.DayCountConvention == input.DayCountConvention ||
                    (this.DayCountConvention != null &&
                    this.DayCountConvention.Equals(input.DayCountConvention))
                ) && 
                (
                    this.RollConvention == input.RollConvention ||
                    (this.RollConvention != null &&
                    this.RollConvention.Equals(input.RollConvention))
                ) && 
                (
                    this.PaymentCalendars == input.PaymentCalendars ||
                    this.PaymentCalendars != null &&
                    input.PaymentCalendars != null &&
                    this.PaymentCalendars.SequenceEqual(input.PaymentCalendars)
                ) && 
                (
                    this.ResetCalendars == input.ResetCalendars ||
                    this.ResetCalendars != null &&
                    input.ResetCalendars != null &&
                    this.ResetCalendars.SequenceEqual(input.ResetCalendars)
                ) && 
                (
                    this.SettleDays == input.SettleDays ||
                    (this.SettleDays != null &&
                    this.SettleDays.Equals(input.SettleDays))
                ) && 
                (
                    this.ResetDays == input.ResetDays ||
                    (this.ResetDays != null &&
                    this.ResetDays.Equals(input.ResetDays))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.RollFrequency != null)
                    hashCode = hashCode * 59 + this.RollFrequency.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.PaymentFrequency != null)
                    hashCode = hashCode * 59 + this.PaymentFrequency.GetHashCode();
                if (this.DayCountConvention != null)
                    hashCode = hashCode * 59 + this.DayCountConvention.GetHashCode();
                if (this.RollConvention != null)
                    hashCode = hashCode * 59 + this.RollConvention.GetHashCode();
                if (this.PaymentCalendars != null)
                    hashCode = hashCode * 59 + this.PaymentCalendars.GetHashCode();
                if (this.ResetCalendars != null)
                    hashCode = hashCode * 59 + this.ResetCalendars.GetHashCode();
                if (this.SettleDays != null)
                    hashCode = hashCode * 59 + this.SettleDays.GetHashCode();
                if (this.ResetDays != null)
                    hashCode = hashCode * 59 + this.ResetDays.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                return hashCode;
            }
        }
    }

}
