/*
 * WebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using OpenApiGeneratorTest.WebApi.Client.Client;
using OpenApiGeneratorTest.WebApi.Client.Model;

namespace OpenApiGeneratorTest.WebApi.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebApiApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;WeatherForecast&gt;</returns>
        List<WeatherForecast> GetWeatherForecast(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;WeatherForecast&gt;</returns>
        ApiResponse<List<WeatherForecast>> GetWeatherForecastWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebApiApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;WeatherForecast&gt;</returns>
        System.Threading.Tasks.Task<List<WeatherForecast>> GetWeatherForecastAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;WeatherForecast&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WeatherForecast>>> GetWeatherForecastWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebApiApi : IWebApiApiSync, IWebApiApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebApiApi : IWebApiApi
    {
        private OpenApiGeneratorTest.WebApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebApiApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebApiApi(string basePath)
        {
            this.Configuration = OpenApiGeneratorTest.WebApi.Client.Client.Configuration.MergeConfigurations(
                OpenApiGeneratorTest.WebApi.Client.Client.GlobalConfiguration.Instance,
                new OpenApiGeneratorTest.WebApi.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new OpenApiGeneratorTest.WebApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new OpenApiGeneratorTest.WebApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = OpenApiGeneratorTest.WebApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebApiApi(OpenApiGeneratorTest.WebApi.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = OpenApiGeneratorTest.WebApi.Client.Client.Configuration.MergeConfigurations(
                OpenApiGeneratorTest.WebApi.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new OpenApiGeneratorTest.WebApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new OpenApiGeneratorTest.WebApi.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = OpenApiGeneratorTest.WebApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WebApiApi(OpenApiGeneratorTest.WebApi.Client.Client.ISynchronousClient client, OpenApiGeneratorTest.WebApi.Client.Client.IAsynchronousClient asyncClient, OpenApiGeneratorTest.WebApi.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = OpenApiGeneratorTest.WebApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public OpenApiGeneratorTest.WebApi.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public OpenApiGeneratorTest.WebApi.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public OpenApiGeneratorTest.WebApi.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public OpenApiGeneratorTest.WebApi.Client.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;WeatherForecast&gt;</returns>
        public List<WeatherForecast> GetWeatherForecast(int operationIndex = 0)
        {
            OpenApiGeneratorTest.WebApi.Client.Client.ApiResponse<List<WeatherForecast>> localVarResponse = GetWeatherForecastWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;WeatherForecast&gt;</returns>
        public OpenApiGeneratorTest.WebApi.Client.Client.ApiResponse<List<WeatherForecast>> GetWeatherForecastWithHttpInfo(int operationIndex = 0)
        {
            OpenApiGeneratorTest.WebApi.Client.Client.RequestOptions localVarRequestOptions = new OpenApiGeneratorTest.WebApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = OpenApiGeneratorTest.WebApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = OpenApiGeneratorTest.WebApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "WebApiApi.GetWeatherForecast";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<WeatherForecast>>("/weatherforecast", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWeatherForecast", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;WeatherForecast&gt;</returns>
        public async System.Threading.Tasks.Task<List<WeatherForecast>> GetWeatherForecastAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            OpenApiGeneratorTest.WebApi.Client.Client.ApiResponse<List<WeatherForecast>> localVarResponse = await GetWeatherForecastWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="OpenApiGeneratorTest.WebApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;WeatherForecast&gt;)</returns>
        public async System.Threading.Tasks.Task<OpenApiGeneratorTest.WebApi.Client.Client.ApiResponse<List<WeatherForecast>>> GetWeatherForecastWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            OpenApiGeneratorTest.WebApi.Client.Client.RequestOptions localVarRequestOptions = new OpenApiGeneratorTest.WebApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = OpenApiGeneratorTest.WebApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = OpenApiGeneratorTest.WebApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "WebApiApi.GetWeatherForecast";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<WeatherForecast>>("/weatherforecast", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWeatherForecast", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
