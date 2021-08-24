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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITranslationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Translate instruments
        /// </summary>
        /// <remarks>
        /// Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>TranslateInstrumentDefinitionsResponse</returns>
        TranslateInstrumentDefinitionsResponse TranslateInstrumentDefinitions (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest);

        /// <summary>
        /// [EXPERIMENTAL] Translate instruments
        /// </summary>
        /// <remarks>
        /// Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>ApiResponse of TranslateInstrumentDefinitionsResponse</returns>
        ApiResponse<TranslateInstrumentDefinitionsResponse> TranslateInstrumentDefinitionsWithHttpInfo (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Translate instruments
        /// </summary>
        /// <remarks>
        /// Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>Task of TranslateInstrumentDefinitionsResponse</returns>
        System.Threading.Tasks.Task<TranslateInstrumentDefinitionsResponse> TranslateInstrumentDefinitionsAsync (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest);

        /// <summary>
        /// [EXPERIMENTAL] Translate instruments
        /// </summary>
        /// <remarks>
        /// Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </remarks>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>Task of ApiResponse (TranslateInstrumentDefinitionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TranslateInstrumentDefinitionsResponse>> TranslateInstrumentDefinitionsAsyncWithHttpInfo (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TranslationApi : ITranslationApi
    {
        private Lusid.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TranslationApi(String basePath)
        {
            this.Configuration = new Lusid.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationApi"/> class
        /// </summary>
        /// <returns></returns>
        public TranslationApi()
        {
            this.Configuration = Lusid.Sdk.Client.Configuration.Default;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TranslationApi(Lusid.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Lusid.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Lusid.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// [EXPERIMENTAL] Translate instruments Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>TranslateInstrumentDefinitionsResponse</returns>
        public TranslateInstrumentDefinitionsResponse TranslateInstrumentDefinitions (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest)
        {
             ApiResponse<TranslateInstrumentDefinitionsResponse> localVarResponse = TranslateInstrumentDefinitionsWithHttpInfo(translateInstrumentDefinitionsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] Translate instruments Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>ApiResponse of TranslateInstrumentDefinitionsResponse</returns>
        public ApiResponse< TranslateInstrumentDefinitionsResponse > TranslateInstrumentDefinitionsWithHttpInfo (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest)
        {
            // verify the required parameter 'translateInstrumentDefinitionsRequest' is set
            if (translateInstrumentDefinitionsRequest == null)
                throw new ApiException(400, "Missing required parameter 'translateInstrumentDefinitionsRequest' when calling TranslationApi->TranslateInstrumentDefinitions");

            var localVarPath = "./api/translation/instrumentdefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (translateInstrumentDefinitionsRequest != null && translateInstrumentDefinitionsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(translateInstrumentDefinitionsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = translateInstrumentDefinitionsRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.11.3421";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TranslateInstrumentDefinitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TranslateInstrumentDefinitionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TranslateInstrumentDefinitionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranslateInstrumentDefinitionsResponse)));
        }

        /// <summary>
        /// [EXPERIMENTAL] Translate instruments Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>Task of TranslateInstrumentDefinitionsResponse</returns>
        public async System.Threading.Tasks.Task<TranslateInstrumentDefinitionsResponse> TranslateInstrumentDefinitionsAsync (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest)
        {
             ApiResponse<TranslateInstrumentDefinitionsResponse> localVarResponse = await TranslateInstrumentDefinitionsAsyncWithHttpInfo(translateInstrumentDefinitionsRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EXPERIMENTAL] Translate instruments Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.
        /// </summary>
        /// <exception cref="Lusid.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="translateInstrumentDefinitionsRequest">The definitions of the instruments to translate along with the target dialect.</param>
        /// <returns>Task of ApiResponse (TranslateInstrumentDefinitionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TranslateInstrumentDefinitionsResponse>> TranslateInstrumentDefinitionsAsyncWithHttpInfo (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest)
        {
            // verify the required parameter 'translateInstrumentDefinitionsRequest' is set
            if (translateInstrumentDefinitionsRequest == null)
                throw new ApiException(400, "Missing required parameter 'translateInstrumentDefinitionsRequest' when calling TranslationApi->TranslateInstrumentDefinitions");

            var localVarPath = "./api/translation/instrumentdefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (translateInstrumentDefinitionsRequest != null && translateInstrumentDefinitionsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(translateInstrumentDefinitionsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = translateInstrumentDefinitionsRequest; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.11.3421";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TranslateInstrumentDefinitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TranslateInstrumentDefinitionsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (TranslateInstrumentDefinitionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranslateInstrumentDefinitionsResponse)));
        }

    }
}