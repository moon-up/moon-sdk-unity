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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable
    {
        private AccountsApi instance;

        public AccountsApiTests()
        {
            instance = new AccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountsApi
            //Assert.IsType<AccountsApi>(instance);
        }

        /// <summary>
        /// Test BroadcastTx
        /// </summary>
        [Fact]
        public void BroadcastTxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //BroadcastInput broadcastInput = null;
            //var response = instance.BroadcastTx(authorization, accountName, broadcastInput);
            //Assert.IsType<BroadCastRawTransactionAPIResponse>(response);
        }

        /// <summary>
        /// Test CreateAccount
        /// </summary>
        [Fact]
        public void CreateAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //CreateAccountInput createAccountInput = null;
            //var response = instance.CreateAccount(authorization, createAccountInput);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test DeleteAccount
        /// </summary>
        [Fact]
        public void DeleteAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //var response = instance.DeleteAccount(authorization, accountName);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test DeployContract
        /// </summary>
        [Fact]
        public void DeployContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //DeployInput deployInput = null;
            //var response = instance.DeployContract(authorization, accountName, deployInput);
            //Assert.IsType<TransactionAPIResponse>(response);
        }

        /// <summary>
        /// Test GetAccount
        /// </summary>
        [Fact]
        public void GetAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string accountName = null;
            //var response = instance.GetAccount(authorization, accountName);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test GetBalance
        /// </summary>
        [Fact]
        public void GetBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountName = null;
            //string authorization = null;
            //string chainId = null;
            //var response = instance.GetBalance(accountName, authorization, chainId);
            //Assert.IsType<BalanceAPIResponse>(response);
        }

        /// <summary>
        /// Test GetNonce
        /// </summary>
        [Fact]
        public void GetNonceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountName = null;
            //string authorization = null;
            //var response = instance.GetNonce(accountName, authorization);
            //Assert.IsType<NonceAPIResponse>(response);
        }

        /// <summary>
        /// Test ListAccounts
        /// </summary>
        [Fact]
        public void ListAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.ListAccounts(authorization);
            //Assert.IsType<AccountAPIResponse>(response);
        }

        /// <summary>
        /// Test SignMessage
        /// </summary>
        [Fact]
        public void SignMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountName = null;
            //string authorization = null;
            //SignMessage signMessage = null;
            //var response = instance.SignMessage(accountName, authorization, signMessage);
            //Assert.IsType<SignMessageAPIResponse>(response);
        }

        /// <summary>
        /// Test SignTransaction
        /// </summary>
        [Fact]
        public void SignTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountName = null;
            //string authorization = null;
            //InputBody inputBody = null;
            //var response = instance.SignTransaction(accountName, authorization, inputBody);
            //Assert.IsType<TransactionAPIResponse>(response);
        }

        /// <summary>
        /// Test SignTypedData
        /// </summary>
        [Fact]
        public void SignTypedDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountName = null;
            //string authorization = null;
            //SignTypedData signTypedData = null;
            //var response = instance.SignTypedData(accountName, authorization, signTypedData);
            //Assert.IsType<SignMessageAPIResponse>(response);
        }

        /// <summary>
        /// Test TransferEth
        /// </summary>
        [Fact]
        public void TransferEthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountName = null;
            //string authorization = null;
            //InputBody inputBody = null;
            //var response = instance.TransferEth(accountName, authorization, inputBody);
            //Assert.IsType<TransactionAPIResponse>(response);
        }
    }
}
