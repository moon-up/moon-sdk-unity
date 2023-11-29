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
    ///  Class for testing YearnApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class YearnApiTests : IDisposable
    {
        private YearnApi instance;

        public YearnApiTests()
        {
            instance = new YearnApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of YearnApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' YearnApi
            //Assert.IsType<YearnApi>(instance);
        }

        /// <summary>
        /// Test AddLiquidity
        /// </summary>
        [Fact]
        public void AddLiquidityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //InputBody inputBody = null;
            //var response = instance.AddLiquidity(authorization, name, inputBody);
            //Assert.IsType<AccountControllerResponse>(response);
        }

        /// <summary>
        /// Test AddLiquidityWeth
        /// </summary>
        [Fact]
        public void AddLiquidityWethTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //InputBody inputBody = null;
            //var response = instance.AddLiquidityWeth(authorization, name, inputBody);
            //Assert.IsType<AccountControllerResponse>(response);
        }

        /// <summary>
        /// Test RemoveLiquidity
        /// </summary>
        [Fact]
        public void RemoveLiquidityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //InputBody inputBody = null;
            //var response = instance.RemoveLiquidity(authorization, name, inputBody);
            //Assert.IsType<AccountControllerResponse>(response);
        }

        /// <summary>
        /// Test RemoveLiquidityWeth
        /// </summary>
        [Fact]
        public void RemoveLiquidityWethTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string name = null;
            //InputBody inputBody = null;
            //var response = instance.RemoveLiquidityWeth(authorization, name, inputBody);
            //Assert.IsType<AccountControllerResponse>(response);
        }
    }
}