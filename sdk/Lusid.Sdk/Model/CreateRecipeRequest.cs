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
    /// Specification class to request for the creation/supplementing of a configuration recipe
    /// </summary>
    [DataContract]
    public partial class CreateRecipeRequest :  IEquatable<CreateRecipeRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRecipeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipeRequest" /> class.
        /// </summary>
        /// <param name="recipeCreationMarketDataScopes">The scopes in which the recipe creation would look for quotes/data. (required).</param>
        /// <param name="recipeId">recipeId.</param>
        /// <param name="inlineRecipe">inlineRecipe.</param>
        /// <param name="asAt">The asAt date to use.</param>
        /// <param name="effectiveAt">The market data time, i.e. the recipe generated will look for rules with this effectiveAt. (required).</param>
        public CreateRecipeRequest(List<string> recipeCreationMarketDataScopes = default(List<string>), ResourceId recipeId = default(ResourceId), ConfigurationRecipe inlineRecipe = default(ConfigurationRecipe), DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // to ensure "recipeCreationMarketDataScopes" is required (not null)
            if (recipeCreationMarketDataScopes == null)
            {
                throw new InvalidDataException("recipeCreationMarketDataScopes is a required property for CreateRecipeRequest and cannot be null");
            }
            else
            {
                this.RecipeCreationMarketDataScopes = recipeCreationMarketDataScopes;
            }
            
            this.AsAt = asAt;
            // to ensure "effectiveAt" is required (not null)
            if (effectiveAt == null)
            {
                throw new InvalidDataException("effectiveAt is a required property for CreateRecipeRequest and cannot be null");
            }
            else
            {
                this.EffectiveAt = effectiveAt;
            }
            
            this.RecipeId = recipeId;
            this.InlineRecipe = inlineRecipe;
            this.AsAt = asAt;
        }
        
        /// <summary>
        /// The scopes in which the recipe creation would look for quotes/data.
        /// </summary>
        /// <value>The scopes in which the recipe creation would look for quotes/data.</value>
        [DataMember(Name="recipeCreationMarketDataScopes", EmitDefaultValue=false)]
        public List<string> RecipeCreationMarketDataScopes { get; set; }

        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name="recipeId", EmitDefaultValue=false)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// Gets or Sets InlineRecipe
        /// </summary>
        [DataMember(Name="inlineRecipe", EmitDefaultValue=false)]
        public ConfigurationRecipe InlineRecipe { get; set; }

        /// <summary>
        /// The asAt date to use
        /// </summary>
        /// <value>The asAt date to use</value>
        [DataMember(Name="asAt", EmitDefaultValue=true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// The market data time, i.e. the recipe generated will look for rules with this effectiveAt.
        /// </summary>
        /// <value>The market data time, i.e. the recipe generated will look for rules with this effectiveAt.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRecipeRequest {\n");
            sb.Append("  RecipeCreationMarketDataScopes: ").Append(RecipeCreationMarketDataScopes).Append("\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  InlineRecipe: ").Append(InlineRecipe).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as CreateRecipeRequest);
        }

        /// <summary>
        /// Returns true if CreateRecipeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRecipeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRecipeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipeCreationMarketDataScopes == input.RecipeCreationMarketDataScopes ||
                    this.RecipeCreationMarketDataScopes != null &&
                    input.RecipeCreationMarketDataScopes != null &&
                    this.RecipeCreationMarketDataScopes.SequenceEqual(input.RecipeCreationMarketDataScopes)
                ) && 
                (
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.InlineRecipe == input.InlineRecipe ||
                    (this.InlineRecipe != null &&
                    this.InlineRecipe.Equals(input.InlineRecipe))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.RecipeCreationMarketDataScopes != null)
                    hashCode = hashCode * 59 + this.RecipeCreationMarketDataScopes.GetHashCode();
                if (this.RecipeId != null)
                    hashCode = hashCode * 59 + this.RecipeId.GetHashCode();
                if (this.InlineRecipe != null)
                    hashCode = hashCode * 59 + this.InlineRecipe.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
