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
using NUnit.Framework;

using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Api;
// uncomment below to import models
//using com.usemoon.MoonSDK.Model;

namespace com.usemoon.MoonSDK.Test.Api
{
    /// <summary>
    ///  Class for testing Erc4337Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class Erc4337ApiTests : IDisposable
    {
        private Erc4337Api instance;

        public Erc4337ApiTests()
        {
            instance = new Erc4337Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Erc4337Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' Erc4337Api
            //Assert.IsType<Erc4337Api>(instance);
        }

        /// <summary>
        /// Test GetAddress
        /// </summary>
        [Test]
        public void GetAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //InputBody inputBody = null;
            //var response = instance.GetAddress(authorization, accountName, inputBody);
            //Assert.IsType<AccountControllerResponse>(response);
        }

        /// <summary>
        /// Test SignBroadcastUserOpTx
        /// </summary>
        [Test]
        public void SignBroadcastUserOpTxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //InputBody inputBody = null;
            //var response = instance.SignBroadcastUserOpTx(authorization, accountName, inputBody);
            //Assert.IsType<AccountControllerResponse>(response);
        }
    }
}
