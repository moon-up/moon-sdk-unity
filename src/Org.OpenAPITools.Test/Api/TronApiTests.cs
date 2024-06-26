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
    ///  Class for testing TronApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TronApiTests : IDisposable
    {
        private TronApi instance;

        public TronApiTests()
        {
            instance = new TronApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TronApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TronApi
            //Assert.IsType<TronApi>(instance);
        }

        /// <summary>
        /// Test CreateTronAccount
        /// </summary>
        [Fact]
        public void CreateTronAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //TronInput tronInput = null;
            //var response = instance.CreateTronAccount(authorization, tronInput);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test GetTronAccount
        /// </summary>
        [Fact]
        public void GetTronAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //var response = instance.GetTronAccount(authorization, accountName);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test ListTronAccounts
        /// </summary>
        [Fact]
        public void ListTronAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.ListTronAccounts(authorization);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test SignTronTransaction
        /// </summary>
        [Fact]
        public void SignTronTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //TronTransactionInput tronTransactionInput = null;
            //var response = instance.SignTronTransaction(authorization, accountName, tronTransactionInput);
            //Assert.IsType<TronAPIResponse>(response);
        }
    }
}
