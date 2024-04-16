/*
 * moon-vault-api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing EosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EosApiTests : IDisposable
    {
        private EosApi instance;

        public EosApiTests()
        {
            instance = new EosApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EosApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EosApi
            //Assert.IsType<EosApi>(instance);
        }

        /// <summary>
        /// Test CreateEosAccount
        /// </summary>
        [Fact]
        public void CreateEosAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //EosInput eosInput = null;
            //var response = instance.CreateEosAccount(authorization, eosInput);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test GetEosAccount
        /// </summary>
        [Fact]
        public void GetEosAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //var response = instance.GetEosAccount(authorization, accountName);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test ListEosAccounts
        /// </summary>
        [Fact]
        public void ListEosAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.ListEosAccounts(authorization);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test SignEosTransaction
        /// </summary>
        [Fact]
        public void SignEosTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //EosTransactionInput eosTransactionInput = null;
            //var response = instance.SignEosTransaction(authorization, accountName, eosTransactionInput);
            //Assert.IsType<EosAPIResponse>(response);
        }
    }
}
