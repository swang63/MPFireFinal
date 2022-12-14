/* 
 * Dowding HTTP REST API
 *
 * The Dowding HTTP REST API allows you to add and retrieve contact data from Dowding as well as perform other peripheral functions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Dowding.Client;
using Dowding.Model;

namespace Dowding.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperatorTickApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;OperatorTick&gt;</returns>
        List<OperatorTick> OperatorTickGet ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;OperatorTick&gt;</returns>
        ApiResponse<List<OperatorTick>> OperatorTickGetWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>OperatorTick</returns>
        OperatorTick OperatorTickIdGet (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of OperatorTick</returns>
        ApiResponse<OperatorTick> OperatorTickIdGetWithHttpInfo (string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>OperatorTick</returns>
        OperatorTick OperatorTickPost (OperatorTickDto operatorTickDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>ApiResponse of OperatorTick</returns>
        ApiResponse<OperatorTick> OperatorTickPostWithHttpInfo (OperatorTickDto operatorTickDto);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;OperatorTick&gt;</returns>
        System.Threading.Tasks.Task<List<OperatorTick>> OperatorTickGetAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;OperatorTick&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OperatorTick>>> OperatorTickGetAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of OperatorTick</returns>
        System.Threading.Tasks.Task<OperatorTick> OperatorTickIdGetAsync (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (OperatorTick)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperatorTick>> OperatorTickIdGetAsyncWithHttpInfo (string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>Task of OperatorTick</returns>
        System.Threading.Tasks.Task<OperatorTick> OperatorTickPostAsync (OperatorTickDto operatorTickDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>Task of ApiResponse (OperatorTick)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperatorTick>> OperatorTickPostAsyncWithHttpInfo (OperatorTickDto operatorTickDto);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OperatorTickApi : IOperatorTickApi
    {
        private Dowding.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorTickApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperatorTickApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Dowding.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorTickApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperatorTickApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Dowding.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Dowding.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;OperatorTick&gt;</returns>
        public List<OperatorTick> OperatorTickGet ()
        {
             ApiResponse<List<OperatorTick>> localVarResponse = OperatorTickGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;OperatorTick&gt;</returns>
        public ApiResponse< List<OperatorTick> > OperatorTickGetWithHttpInfo ()
        {

            var localVarPath = "/operator-tick";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OperatorTickGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<OperatorTick>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OperatorTick>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OperatorTick>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;OperatorTick&gt;</returns>
        public async System.Threading.Tasks.Task<List<OperatorTick>> OperatorTickGetAsync ()
        {
             ApiResponse<List<OperatorTick>> localVarResponse = await OperatorTickGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;OperatorTick&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OperatorTick>>> OperatorTickGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/operator-tick";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OperatorTickGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<OperatorTick>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OperatorTick>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OperatorTick>)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>OperatorTick</returns>
        public OperatorTick OperatorTickIdGet (string id)
        {
             ApiResponse<OperatorTick> localVarResponse = OperatorTickIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of OperatorTick</returns>
        public ApiResponse< OperatorTick > OperatorTickIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperatorTickApi->OperatorTickIdGet");

            var localVarPath = "/operator-tick/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OperatorTickIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperatorTick>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperatorTick) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperatorTick)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of OperatorTick</returns>
        public async System.Threading.Tasks.Task<OperatorTick> OperatorTickIdGetAsync (string id)
        {
             ApiResponse<OperatorTick> localVarResponse = await OperatorTickIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (OperatorTick)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperatorTick>> OperatorTickIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperatorTickApi->OperatorTickIdGet");

            var localVarPath = "/operator-tick/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OperatorTickIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperatorTick>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperatorTick) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperatorTick)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>OperatorTick</returns>
        public OperatorTick OperatorTickPost (OperatorTickDto operatorTickDto)
        {
             ApiResponse<OperatorTick> localVarResponse = OperatorTickPostWithHttpInfo(operatorTickDto);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>ApiResponse of OperatorTick</returns>
        public ApiResponse< OperatorTick > OperatorTickPostWithHttpInfo (OperatorTickDto operatorTickDto)
        {
            // verify the required parameter 'operatorTickDto' is set
            if (operatorTickDto == null)
                throw new ApiException(400, "Missing required parameter 'operatorTickDto' when calling OperatorTickApi->OperatorTickPost");

            var localVarPath = "/operator-tick";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (operatorTickDto != null && operatorTickDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operatorTickDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operatorTickDto; // byte array
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OperatorTickPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperatorTick>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperatorTick) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperatorTick)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>Task of OperatorTick</returns>
        public async System.Threading.Tasks.Task<OperatorTick> OperatorTickPostAsync (OperatorTickDto operatorTickDto)
        {
             ApiResponse<OperatorTick> localVarResponse = await OperatorTickPostAsyncWithHttpInfo(operatorTickDto);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Dowding.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operatorTickDto"></param>
        /// <returns>Task of ApiResponse (OperatorTick)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperatorTick>> OperatorTickPostAsyncWithHttpInfo (OperatorTickDto operatorTickDto)
        {
            // verify the required parameter 'operatorTickDto' is set
            if (operatorTickDto == null)
                throw new ApiException(400, "Missing required parameter 'operatorTickDto' when calling OperatorTickApi->OperatorTickPost");

            var localVarPath = "/operator-tick";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (operatorTickDto != null && operatorTickDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(operatorTickDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = operatorTickDto; // byte array
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OperatorTickPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperatorTick>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperatorTick) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperatorTick)));
            
        }

    }
}
