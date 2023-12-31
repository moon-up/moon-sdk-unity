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
    ///  Class for testing OnramperApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnramperApiTests : IDisposable
    {
        private OnramperApi instance;

        public OnramperApiTests()
        {
            instance = new OnramperApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnramperApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OnramperApi
            //Assert.IsType<OnramperApi>(instance);
        }

        /// <summary>
        /// Test OnRamperCheckout
        /// </summary>
        [Test]
        public void OnRamperCheckoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //TransactionInput transactionInput = null;
            //var response = instance.OnRamperCheckout(authorization, accountName, transactionInput);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test OnRamperGetQuotesBuy
        /// </summary>
        [Test]
        public void OnRamperGetQuotesBuyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string fiat = null;
            //string crypto = null;
            //double amount = null;
            //string? paymentMethod = null;
            //string? uuid = null;
            //string? clientName = null;
            //string? country = null;
            //var response = instance.OnRamperGetQuotesBuy(authorization, fiat, crypto, amount, paymentMethod, uuid, clientName, country);
            //Assert.IsType<List<Quote>>(response);
        }

        /// <summary>
        /// Test OnRamperGetQuotesSell
        /// </summary>
        [Test]
        public void OnRamperGetQuotesSellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string fiat = null;
            //string crypto = null;
            //double amount = null;
            //string? paymentMethod = null;
            //string? uuid = null;
            //string? clientName = null;
            //string? country = null;
            //var response = instance.OnRamperGetQuotesSell(authorization, fiat, crypto, amount, paymentMethod, uuid, clientName, country);
            //Assert.IsType<List<SellQuote>>(response);
        }

        /// <summary>
        /// Test OnRamperGetSupportedAssets
        /// </summary>
        [Test]
        public void OnRamperGetSupportedAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string source = null;
            //string country = null;
            //var response = instance.OnRamperGetSupportedAssets(authorization, source, country);
            //Assert.IsType<SupportedAssetResponse>(response);
        }

        /// <summary>
        /// Test OnRamperGetSupportedCurrencies
        /// </summary>
        [Test]
        public void OnRamperGetSupportedCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string type = null;
            //var response = instance.OnRamperGetSupportedCurrencies(authorization, type);
            //Assert.IsType<SupportedCurrenciesResponse>(response);
        }

        /// <summary>
        /// Test OnRamperGetSupportedDefaultsAll
        /// </summary>
        [Test]
        public void OnRamperGetSupportedDefaultsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string country = null;
            //string type = null;
            //var response = instance.OnRamperGetSupportedDefaultsAll(authorization, country, type);
            //Assert.IsType<SupportedDefaultResponse>(response);
        }

        /// <summary>
        /// Test OnRamperGetSupportedOnRampsAll
        /// </summary>
        [Test]
        public void OnRamperGetSupportedOnRampsAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.OnRamperGetSupportedOnRampsAll(authorization);
            //Assert.IsType<GetSupportedOnRampsResponse>(response);
        }

        /// <summary>
        /// Test OnRamperGetSupportedPaymentTypes
        /// </summary>
        [Test]
        public void OnRamperGetSupportedPaymentTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string fiat = null;
            //string country = null;
            //string type = null;
            //var response = instance.OnRamperGetSupportedPaymentTypes(authorization, fiat, country, type);
            //Assert.IsType<SupportedPaymentTypesCurrencyResponse>(response);
        }

        /// <summary>
        /// Test OnRamperGetSupportedPaymentTypesFiat
        /// </summary>
        [Test]
        public void OnRamperGetSupportedPaymentTypesFiatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string fiat = null;
            //string country = null;
            //var response = instance.OnRamperGetSupportedPaymentTypesFiat(authorization, fiat, country);
            //Assert.IsType<SupportedPaymentTypesCurrencyResponse>(response);
        }
    }
}
