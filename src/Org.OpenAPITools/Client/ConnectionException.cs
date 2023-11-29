/*
 * moon-vault-api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using UnityEngine.Networking;

namespace Org.OpenAPITools.Client
{
    public class ConnectionException : Exception
    {
        public UnityWebRequest.Result Result { get; private set; }
        public string Error { get; private set; }

        // NOTE: Cannot keep reference to the request since it will be disposed.
        public ConnectionException(UnityWebRequest request)
            : base($"result={request.result} error={request.error}")
        {
            Result = request.result;
            Error = request.error ?? "";
        }
    }
}
