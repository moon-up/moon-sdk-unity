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
    ///  Class for testing AaveApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AaveApiTests : IDisposable
    {
        private AaveApi instance;

        public AaveApiTests()
        {
            instance = new AaveApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AaveApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AaveApi
            //Assert.IsType<AaveApi>(instance);
        }

        /// <summary>
        /// Test Borrow
        /// </summary>
        [Fact]
        public void BorrowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //AaveInput aaveInput = null;
            //var response = instance.Borrow(authorization, name, aaveInput);
            //Assert.IsType<TransactionAPIResponse>(response);
        }

        /// <summary>
        /// Test Lend
        /// </summary>
        [Fact]
        public void LendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //AaveInput aaveInput = null;
            //var response = instance.Lend(authorization, name, aaveInput);
            //Assert.IsType<TransactionAPIResponse>(response);
        }

        /// <summary>
        /// Test Repay
        /// </summary>
        [Fact]
        public void RepayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //AaveInput aaveInput = null;
            //var response = instance.Repay(authorization, name, aaveInput);
            //Assert.IsType<TransactionAPIResponse>(response);
        }

        /// <summary>
        /// Test UserReserveData
        /// </summary>
        [Fact]
        public void UserReserveDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //AaveInput aaveInput = null;
            //var response = instance.UserReserveData(authorization, name, aaveInput);
            //Assert.IsType<AaveReservesAPIResponse>(response);
        }
    }
}
