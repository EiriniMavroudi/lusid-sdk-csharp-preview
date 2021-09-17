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
    /// SequenceDefinition
    /// </summary>
    [DataContract(Name = "SequenceDefinition")]
    public partial class SequenceDefinition : IEquatable<SequenceDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SequenceDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SequenceDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SequenceDefinition" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="increment">The Resource Id of the sequence definition (required).</param>
        /// <param name="minValue">The minimum value of the sequence (required).</param>
        /// <param name="maxValue">The maximum value of the sequence (required).</param>
        /// <param name="start">The start value of the sequence (required).</param>
        /// <param name="value">The last used value of the sequence (required).</param>
        /// <param name="cycle">Indicates if the sequence would start from minimun value once it reaches maximum value. If set to false, a failure would return if the sequence reaches maximum value. (required).</param>
        /// <param name="pattern">The pattern to be used to generate next values in the sequence. (required).</param>
        /// <param name="links">Collection of links..</param>
        public SequenceDefinition(ResourceId id = default(ResourceId), long increment = default(long), long minValue = default(long), long maxValue = default(long), long start = default(long), long value = default(long), bool cycle = default(bool), string pattern = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for SequenceDefinition and cannot be null");
            this.Increment = increment;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Start = start;
            this.Value = value;
            this.Cycle = cycle;
            // to ensure "pattern" is required (not null)
            this.Pattern = pattern ?? throw new ArgumentNullException("pattern is a required property for SequenceDefinition and cannot be null");
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The Resource Id of the sequence definition
        /// </summary>
        /// <value>The Resource Id of the sequence definition</value>
        [DataMember(Name = "increment", IsRequired = true, EmitDefaultValue = false)]
        public long Increment { get; set; }

        /// <summary>
        /// The minimum value of the sequence
        /// </summary>
        /// <value>The minimum value of the sequence</value>
        [DataMember(Name = "minValue", IsRequired = true, EmitDefaultValue = false)]
        public long MinValue { get; set; }

        /// <summary>
        /// The maximum value of the sequence
        /// </summary>
        /// <value>The maximum value of the sequence</value>
        [DataMember(Name = "maxValue", IsRequired = true, EmitDefaultValue = false)]
        public long MaxValue { get; set; }

        /// <summary>
        /// The start value of the sequence
        /// </summary>
        /// <value>The start value of the sequence</value>
        [DataMember(Name = "start", IsRequired = true, EmitDefaultValue = false)]
        public long Start { get; set; }

        /// <summary>
        /// The last used value of the sequence
        /// </summary>
        /// <value>The last used value of the sequence</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public long Value { get; set; }

        /// <summary>
        /// Indicates if the sequence would start from minimun value once it reaches maximum value. If set to false, a failure would return if the sequence reaches maximum value.
        /// </summary>
        /// <value>Indicates if the sequence would start from minimun value once it reaches maximum value. If set to false, a failure would return if the sequence reaches maximum value.</value>
        [DataMember(Name = "cycle", IsRequired = true, EmitDefaultValue = true)]
        public bool Cycle { get; set; }

        /// <summary>
        /// The pattern to be used to generate next values in the sequence.
        /// </summary>
        /// <value>The pattern to be used to generate next values in the sequence.</value>
        [DataMember(Name = "pattern", IsRequired = true, EmitDefaultValue = false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SequenceDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Increment: ").Append(Increment).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Cycle: ").Append(Cycle).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as SequenceDefinition);
        }

        /// <summary>
        /// Returns true if SequenceDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of SequenceDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SequenceDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Increment == input.Increment ||
                    this.Increment.Equals(input.Increment)
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    this.MinValue.Equals(input.MinValue)
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    this.MaxValue.Equals(input.MaxValue)
                ) && 
                (
                    this.Start == input.Start ||
                    this.Start.Equals(input.Start)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Cycle == input.Cycle ||
                    this.Cycle.Equals(input.Cycle)
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Increment.GetHashCode();
                hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                hashCode = hashCode * 59 + this.Start.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Cycle.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}