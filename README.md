# com.usemoon.MoonSDK - the C# library for the moon-vault-api

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="version-support"></a>
## Version support
This generator should support all current LTS versions of Unity
- Unity 2020.3 (LTS) and up
- .NET Standard 2.1 / .NET Framework

<a id="dependencies"></a>
## Dependencies

- [Newtonsoft.Json](https://docs.unity3d.com/Packages/com.unity.nuget.newtonsoft-json@3.0/manual/index.html) - 3.0.2 or later
- [Unity Test Framework](https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html) - 1.1.33 or later

<a id="installation"></a>
## Installation
Add the dependencies to `Packages/manifest.json`
```
{
  "dependencies": {
    ...
    "com.unity.nuget.newtonsoft-json": "3.0.2",
    "com.unity.test-framework": "1.1.33",
  }
}
```

Then use the namespaces:
```csharp
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Collections.Generic;
using UnityEngine;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace com.usemoon.MoonSDKExample
{

    public class BorrowExample : MonoBehaviour
    {
        async void Start()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vault-api.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AaveApi(config);
            var authorization = "authorization_example";  // string | 
            var name = "name_example";  // string | 
            var aaveInput = new AaveInput(); // AaveInput | 

            try
            {
                AccountControllerResponse result = await apiInstance.BorrowAsync(authorization, name, aaveInput);
                Debug.Log(result);
                Debug.Log("Done!");
            }
            catch (ApiException e)
            {
                Debug.LogError("Exception when calling AaveApi.Borrow: " + e.Message );
                Debug.LogError("Status Code: "+ e.ErrorCode);
                Debug.LogError(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://vault-api.usemoon.ai*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AaveApi* | [**Borrow**](AaveApi.md#borrow) | **POST** /aave/{name}/borrow | 
*AaveApi* | [**Lend**](AaveApi.md#lend) | **POST** /aave/{name}/lend | 
*AaveApi* | [**Repay**](AaveApi.md#repay) | **POST** /aave/{name}/repay | 
*AaveApi* | [**UserReserveData**](AaveApi.md#userreservedata) | **POST** /aave/{name}/user-reserve-data | 
*AccountsApi* | [**BroadcastTx**](AccountsApi.md#broadcasttx) | **POST** /accounts/{accountName}/broadcast-tx | 
*AccountsApi* | [**CreateAccount**](AccountsApi.md#createaccount) | **POST** /accounts | 
*AccountsApi* | [**DeleteAccount**](AccountsApi.md#deleteaccount) | **DELETE** /accounts/{accountName} | 
*AccountsApi* | [**DeployContract**](AccountsApi.md#deploycontract) | **POST** /accounts/{accountName}/deploy | 
*AccountsApi* | [**GetAccount**](AccountsApi.md#getaccount) | **GET** /accounts/{accountName} | 
*AccountsApi* | [**GetBalance**](AccountsApi.md#getbalance) | **GET** /accounts/{accountName}/balance | 
*AccountsApi* | [**GetNonce**](AccountsApi.md#getnonce) | **GET** /accounts/{accountName}/nonce | 
*AccountsApi* | [**ListAccounts**](AccountsApi.md#listaccounts) | **GET** /accounts | 
*AccountsApi* | [**SignMessage**](AccountsApi.md#signmessage) | **POST** /accounts/{accountName}/sign-message | 
*AccountsApi* | [**SignTransaction**](AccountsApi.md#signtransaction) | **POST** /accounts/{accountName}/sign-transaction | 
*AccountsApi* | [**SignTypedData**](AccountsApi.md#signtypeddata) | **POST** /accounts/{accountName}/sign-typed-data | 
*AccountsApi* | [**TransferEth**](AccountsApi.md#transfereth) | **POST** /accounts/{accountName}/transfer-eth | 
*BitcoinApi* | [**CreateBitcoinAccount**](BitcoinApi.md#createbitcoinaccount) | **POST** /bitcoin | 
*BitcoinApi* | [**GetBitcoinAccount**](BitcoinApi.md#getbitcoinaccount) | **GET** /bitcoin/{accountName} | 
*BitcoinApi* | [**ListBitcoinAccounts**](BitcoinApi.md#listbitcoinaccounts) | **GET** /bitcoin | 
*BitcoinApi* | [**SignBitcoinTransaction**](BitcoinApi.md#signbitcointransaction) | **POST** /bitcoin/{accountName}/sign-tx | 
*BitcoincashApi* | [**CreateBitcoinCashAccount**](BitcoincashApi.md#createbitcoincashaccount) | **POST** /bitcoincash | 
*BitcoincashApi* | [**GetBitcoinCashAccount**](BitcoincashApi.md#getbitcoincashaccount) | **GET** /bitcoincash/{accountName} | 
*BitcoincashApi* | [**ListBitcoinCashAccounts**](BitcoincashApi.md#listbitcoincashaccounts) | **GET** /bitcoincash | 
*BitcoincashApi* | [**SignBitcoinCashTransaction**](BitcoincashApi.md#signbitcoincashtransaction) | **POST** /bitcoincash/{accountName}/sign-tx | 
*ConveyorFinanceApi* | [**Swap**](ConveyorFinanceApi.md#swap) | **POST** /conveyorfinance/{name}/swap | 
*CosmosApi* | [**CreateCosmosAccount**](CosmosApi.md#createcosmosaccount) | **POST** /cosmos | 
*CosmosApi* | [**GetCosmosAccount**](CosmosApi.md#getcosmosaccount) | **GET** /cosmos/{accountName} | 
*CosmosApi* | [**ListCosmosAccounts**](CosmosApi.md#listcosmosaccounts) | **GET** /cosmos | 
*CosmosApi* | [**SignCosmosTransaction**](CosmosApi.md#signcosmostransaction) | **POST** /cosmos/{accountName}/sign-tx | 
*DefaultApi* | [**GetMessage**](DefaultApi.md#getmessage) | **GET** /ping | 
*DogeCoinApi* | [**CreateDogeCoinAccount**](DogeCoinApi.md#createdogecoinaccount) | **POST** /dogecoin | 
*DogeCoinApi* | [**GetDogeCoinAccount**](DogeCoinApi.md#getdogecoinaccount) | **GET** /dogecoin/{accountName} | 
*DogeCoinApi* | [**ListDogeCoinAccounts**](DogeCoinApi.md#listdogecoinaccounts) | **GET** /dogecoin | 
*DogeCoinApi* | [**SignDogeCoinTransaction**](DogeCoinApi.md#signdogecointransaction) | **POST** /dogecoin/{accountName}/sign-tx | 
*ENSApi* | [**Resolve**](ENSApi.md#resolve) | **POST** /ens/resolve | 
*ERC1155Api* | [**BalanceOf**](ERC1155Api.md#balanceof) | **POST** /erc1155/{name}/balance-of | 
*ERC1155Api* | [**BalanceOfBatch**](ERC1155Api.md#balanceofbatch) | **POST** /erc1155/{name}/balance-of-batch | 
*ERC1155Api* | [**IsApprovedForAll**](ERC1155Api.md#isapprovedforall) | **POST** /erc1155/{name}/is-approved-for-all | 
*ERC1155Api* | [**SafeBatchTransferFrom**](ERC1155Api.md#safebatchtransferfrom) | **POST** /erc1155/{name}/safe-batch-transfer-from | 
*ERC1155Api* | [**SafeTransferFrom**](ERC1155Api.md#safetransferfrom) | **POST** /erc1155/{name}/safe-transfer-from | 
*ERC1155Api* | [**SetApprovalForAll**](ERC1155Api.md#setapprovalforall) | **POST** /erc1155/{name}/set-approval-for-all | 
*EosApi* | [**CreateEosAccount**](EosApi.md#createeosaccount) | **POST** /eos | 
*EosApi* | [**GetEosAccount**](EosApi.md#geteosaccount) | **GET** /eos/{accountName} | 
*EosApi* | [**ListEosAccounts**](EosApi.md#listeosaccounts) | **GET** /eos | 
*EosApi* | [**SignEosTransaction**](EosApi.md#signeostransaction) | **POST** /eos/{accountName}/sign-tx | 
*Erc20Api* | [**AllowanceErc20**](Erc20Api.md#allowanceerc20) | **POST** /erc20/{name}/allowance | 
*Erc20Api* | [**ApproveErc20**](Erc20Api.md#approveerc20) | **POST** /erc20/{name}/approve | 
*Erc20Api* | [**BalanceOfErc20**](Erc20Api.md#balanceoferc20) | **POST** /erc20/{name}/balance-of | 
*Erc20Api* | [**DecimalsErc20**](Erc20Api.md#decimalserc20) | **POST** /erc20/{name}/decimals | 
*Erc20Api* | [**NameErc20**](Erc20Api.md#nameerc20) | **POST** /erc20/{name}/name | 
*Erc20Api* | [**SymbolErc20**](Erc20Api.md#symbolerc20) | **POST** /erc20/{name}/symbol | 
*Erc20Api* | [**TotalSupplyErc20**](Erc20Api.md#totalsupplyerc20) | **POST** /erc20/{name}/total-supply | 
*Erc20Api* | [**TransferErc20**](Erc20Api.md#transfererc20) | **POST** /erc20/{name}/transfer | 
*Erc20Api* | [**TransferFromErc20**](Erc20Api.md#transferfromerc20) | **POST** /erc20/{name}/transfer-from | 
*Erc4337Api* | [**GetAddress**](Erc4337Api.md#getaddress) | **POST** /erc4337/{accountName}/address | 
*Erc4337Api* | [**SignBroadcastUserOpTx**](Erc4337Api.md#signbroadcastuseroptx) | **POST** /erc4337/{accountName}/sign-broadcast-userop-tx | 
*Erc721Api* | [**Approve**](Erc721Api.md#approve) | **POST** /erc721/{name}/approve | 
*Erc721Api* | [**BalanceOf**](Erc721Api.md#balanceof) | **POST** /erc721/{name}/balance-of | 
*Erc721Api* | [**GetApproved**](Erc721Api.md#getapproved) | **POST** /erc721/{name}/get-approved | 
*Erc721Api* | [**IsApprovedForAll**](Erc721Api.md#isapprovedforall) | **POST** /erc721/{name}/is-approved-for-all | 
*Erc721Api* | [**Name**](Erc721Api.md#name) | **POST** /erc721/{name}/name | 
*Erc721Api* | [**OwnerOf**](Erc721Api.md#ownerof) | **POST** /erc721/{name}/owner-of | 
*Erc721Api* | [**SafeTransferFrom**](Erc721Api.md#safetransferfrom) | **POST** /erc721/{name}/safe-transfer-from | 
*Erc721Api* | [**SetApprovalForAll**](Erc721Api.md#setapprovalforall) | **POST** /erc721/{name}/set-approval-for-all | 
*Erc721Api* | [**Symbol**](Erc721Api.md#symbol) | **POST** /erc721/{name}/symbol | 
*Erc721Api* | [**TokenUri**](Erc721Api.md#tokenuri) | **POST** /erc721/{name}/token-uri | 
*Erc721Api* | [**Transfer**](Erc721Api.md#transfer) | **POST** /erc721/{name}/transfer | 
*Erc721Api* | [**TransferFrom**](Erc721Api.md#transferfrom) | **POST** /erc721/{name}/transfer-from | 
*LitecoinApi* | [**CreateLitecoinAccount**](LitecoinApi.md#createlitecoinaccount) | **POST** /litecoin | 
*LitecoinApi* | [**GetLitecoinAccount**](LitecoinApi.md#getlitecoinaccount) | **GET** /litecoin/{accountName} | 
*LitecoinApi* | [**ListLitecoinAccounts**](LitecoinApi.md#listlitecoinaccounts) | **GET** /litecoin | 
*LitecoinApi* | [**SignLitecoinTransaction**](LitecoinApi.md#signlitecointransaction) | **POST** /litecoin/{accountName}/sign-tx | 
*OneinchApi* | [**ApproveCallData**](OneinchApi.md#approvecalldata) | **POST** /oneinch/approve-call-data | 
*OneinchApi* | [**ApproveSpender**](OneinchApi.md#approvespender) | **POST** /oneinch/approve-spender | 
*OneinchApi* | [**Protocols**](OneinchApi.md#protocols) | **POST** /oneinch/protocols | 
*OneinchApi* | [**Quote**](OneinchApi.md#quote) | **POST** /oneinch/quote | 
*OneinchApi* | [**Swap**](OneinchApi.md#swap) | **POST** /oneinch/{accountName}/swap | 
*OneinchApi* | [**Tokens**](OneinchApi.md#tokens) | **POST** /oneinch/tokens | 
*OnramperApi* | [**OnRamperCheckout**](OnramperApi.md#onrampercheckout) | **POST** /onramper/fund/${accountName} | 
*OnramperApi* | [**OnRamperGetQuotesBuy**](OnramperApi.md#onrampergetquotesbuy) | **GET** /onramper/quotes/buy | 
*OnramperApi* | [**OnRamperGetQuotesSell**](OnramperApi.md#onrampergetquotessell) | **GET** /onramper/quotes/sell | 
*OnramperApi* | [**OnRamperGetSupportedAssets**](OnramperApi.md#onrampergetsupportedassets) | **GET** /onramper/assets | 
*OnramperApi* | [**OnRamperGetSupportedCurrencies**](OnramperApi.md#onrampergetsupportedcurrencies) | **GET** /onramper/currencies | 
*OnramperApi* | [**OnRamperGetSupportedDefaultsAll**](OnramperApi.md#onrampergetsupporteddefaultsall) | **GET** /onramper/defaults | 
*OnramperApi* | [**OnRamperGetSupportedOnRampsAll**](OnramperApi.md#onrampergetsupportedonrampsall) | **GET** /onramper/onramps | 
*OnramperApi* | [**OnRamperGetSupportedPaymentTypes**](OnramperApi.md#onrampergetsupportedpaymenttypes) | **GET** /onramper/payment-types | 
*OnramperApi* | [**OnRamperGetSupportedPaymentTypesFiat**](OnramperApi.md#onrampergetsupportedpaymenttypesfiat) | **GET** /onramper/payment-types/fiat | 
*PaymentApi* | [**MoralisWebhook**](PaymentApi.md#moraliswebhook) | **POST** /payment/webhook/{id} | 
*PaymentApi* | [**PaymentCreatePaymentIntent**](PaymentApi.md#paymentcreatepaymentintent) | **POST** /payment | 
*PaymentApi* | [**PaymentDeletePaymentIntent**](PaymentApi.md#paymentdeletepaymentintent) | **DELETE** /payment/{id} | 
*PaymentApi* | [**PaymentGetAllPaymentIntents**](PaymentApi.md#paymentgetallpaymentintents) | **GET** /payment | 
*PaymentApi* | [**PaymentGetAvailableChains**](PaymentApi.md#paymentgetavailablechains) | **GET** /payment/chains | 
*PaymentApi* | [**PaymentGetPaymentIntent**](PaymentApi.md#paymentgetpaymentintent) | **GET** /payment/{id} | 
*PaymentApi* | [**PaymentUpdatePaymentIntent**](PaymentApi.md#paymentupdatepaymentintent) | **PUT** /payment/{id} | 
*PaymentApi* | [**TatumWebhook**](PaymentApi.md#tatumwebhook) | **POST** /payment/tatum/webhook/{id} | 
*RippleApi* | [**CreateRippleAccount**](RippleApi.md#createrippleaccount) | **POST** /ripple | 
*RippleApi* | [**GetRippleAccount**](RippleApi.md#getrippleaccount) | **GET** /ripple/{accountName} | 
*RippleApi* | [**ListRippleAccounts**](RippleApi.md#listrippleaccounts) | **GET** /ripple | 
*RippleApi* | [**SignRippleTransaction**](RippleApi.md#signrippletransaction) | **POST** /ripple/{accountName}/sign-tx | 
*SolanaApi* | [**CreateSolanaAccount**](SolanaApi.md#createsolanaaccount) | **POST** /solana | 
*SolanaApi* | [**GetSolanaAccount**](SolanaApi.md#getsolanaaccount) | **GET** /solana/{accountName} | 
*SolanaApi* | [**ListSolanaAccounts**](SolanaApi.md#listsolanaaccounts) | **GET** /solana | 
*SolanaApi* | [**SignSolanaTransaction**](SolanaApi.md#signsolanatransaction) | **POST** /solana/{accountName}/sign-tx | 
*TronApi* | [**CreateTronAccount**](TronApi.md#createtronaccount) | **POST** /tron | 
*TronApi* | [**GetTronAccount**](TronApi.md#gettronaccount) | **GET** /tron/{accountName} | 
*TronApi* | [**ListTronAccounts**](TronApi.md#listtronaccounts) | **GET** /tron | 
*TronApi* | [**SignTronTransaction**](TronApi.md#signtrontransaction) | **POST** /tron/{accountName}/sign-tx | 
*UniSwapApi* | [**AddLiquidity**](UniSwapApi.md#addliquidity) | **POST** /uniswap/{name}/add-liquidity | 
*UniSwapApi* | [**RemoveLiquidity**](UniSwapApi.md#removeliquidity) | **POST** /uniswap/{name}/remove-liquidity | 
*UniSwapApi* | [**SwapExactETHForTokens**](UniSwapApi.md#swapexactethfortokens) | **POST** /uniswap/{name}/swap-exact-eth-for-tokens | 
*UniSwapApi* | [**SwapExactTokensForTokens**](UniSwapApi.md#swapexacttokensfortokens) | **POST** /uniswap/{name}/swap-exact-tokens-for-tokens | 
*YearnApi* | [**AddLiquidity**](YearnApi.md#addliquidity) | **POST** /yearn/{name}/add-liquidity | 
*YearnApi* | [**AddLiquidityWeth**](YearnApi.md#addliquidityweth) | **POST** /yearn/{name}/add-liquidity-weth | 
*YearnApi* | [**RemoveLiquidity**](YearnApi.md#removeliquidity) | **POST** /yearn/{name}/remove-liquidity | 
*YearnApi* | [**RemoveLiquidityWeth**](YearnApi.md#removeliquidityweth) | **POST** /yearn/{name}/remove-liquidity-weth | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AaveInput](AaveInput.md)
 - [Model.AaveReservesData](AaveReservesData.md)
 - [Model.AbiInput](AbiInput.md)
 - [Model.AbiItem](AbiItem.md)
 - [Model.AbiOutput](AbiOutput.md)
 - [Model.AccountControllerResponse](AccountControllerResponse.md)
 - [Model.AccountControllerResponseData](AccountControllerResponseData.md)
 - [Model.AccountResponse](AccountResponse.md)
 - [Model.AvailablePaymentMethod](AvailablePaymentMethod.md)
 - [Model.BalanceResponse](BalanceResponse.md)
 - [Model.BitcoinCashInput](BitcoinCashInput.md)
 - [Model.BitcoinCashTransactionInput](BitcoinCashTransactionInput.md)
 - [Model.BitcoinInput](BitcoinInput.md)
 - [Model.BitcoinTransactionInput](BitcoinTransactionInput.md)
 - [Model.BitcoinTransactionOutput](BitcoinTransactionOutput.md)
 - [Model.Block](Block.md)
 - [Model.BroadCastRawTransactionResponse](BroadCastRawTransactionResponse.md)
 - [Model.BroadcastInput](BroadcastInput.md)
 - [Model.ConveyorFinanceControllerResponse](ConveyorFinanceControllerResponse.md)
 - [Model.CosmosInput](CosmosInput.md)
 - [Model.CosmosTransactionInput](CosmosTransactionInput.md)
 - [Model.CreateAccountInput](CreateAccountInput.md)
 - [Model.CreatePaymentIntentInput](CreatePaymentIntentInput.md)
 - [Model.CryptoCurrency](CryptoCurrency.md)
 - [Model.DeployInput](DeployInput.md)
 - [Model.DogeCoinInput](DogeCoinInput.md)
 - [Model.DogeCoinTransactionInput](DogeCoinTransactionInput.md)
 - [Model.ENSReverseResolveResponse](ENSReverseResolveResponse.md)
 - [Model.EnsResolveInput](EnsResolveInput.md)
 - [Model.EnsResolveResponse](EnsResolveResponse.md)
 - [Model.EosInput](EosInput.md)
 - [Model.EosTransactionInput](EosTransactionInput.md)
 - [Model.Erc1155Request](Erc1155Request.md)
 - [Model.Erc1155Response](Erc1155Response.md)
 - [Model.Erc20Response](Erc20Response.md)
 - [Model.Erc721Request](Erc721Request.md)
 - [Model.Erc721Response](Erc721Response.md)
 - [Model.FiatCurrency](FiatCurrency.md)
 - [Model.GetSupportedOnRampsResponse](GetSupportedOnRampsResponse.md)
 - [Model.GetSupportedOnRampsResponseMessageInner](GetSupportedOnRampsResponseMessageInner.md)
 - [Model.GetSupportedOnRampsResponseMessageInnerIcons](GetSupportedOnRampsResponseMessageInnerIcons.md)
 - [Model.GetSupportedOnRampsResponseMessageInnerIconsPng](GetSupportedOnRampsResponseMessageInnerIconsPng.md)
 - [Model.GetSwapDto](GetSwapDto.md)
 - [Model.IERC20Approval](IERC20Approval.md)
 - [Model.IERC20Transfer](IERC20Transfer.md)
 - [Model.INFTApproval](INFTApproval.md)
 - [Model.INFTApprovalERC1155](INFTApprovalERC1155.md)
 - [Model.INFTApprovalERC721](INFTApprovalERC721.md)
 - [Model.INFTTransfer](INFTTransfer.md)
 - [Model.INativeBalance](INativeBalance.md)
 - [Model.IOldNFTApproval](IOldNFTApproval.md)
 - [Model.IWebhook](IWebhook.md)
 - [Model.InputBody](InputBody.md)
 - [Model.InternalTransaction](InternalTransaction.md)
 - [Model.LitecoinInput](LitecoinInput.md)
 - [Model.LitecoinTransactionInput](LitecoinTransactionInput.md)
 - [Model.Log](Log.md)
 - [Model.Message](Message.md)
 - [Model.NonceResponse](NonceResponse.md)
 - [Model.PaymentIntentResponse](PaymentIntentResponse.md)
 - [Model.PaymentType](PaymentType.md)
 - [Model.PingResponse](PingResponse.md)
 - [Model.Quote](Quote.md)
 - [Model.RippleInput](RippleInput.md)
 - [Model.RippleTransactionInput](RippleTransactionInput.md)
 - [Model.SellQuote](SellQuote.md)
 - [Model.SignMessage](SignMessage.md)
 - [Model.SignTypedData](SignTypedData.md)
 - [Model.SolanaInput](SolanaInput.md)
 - [Model.SolanaTransactionInput](SolanaTransactionInput.md)
 - [Model.SupportedAssetResponse](SupportedAssetResponse.md)
 - [Model.SupportedAssetResponseAssetsInner](SupportedAssetResponseAssetsInner.md)
 - [Model.SupportedCurrenciesResponse](SupportedCurrenciesResponse.md)
 - [Model.SupportedDefaultResponse](SupportedDefaultResponse.md)
 - [Model.SupportedDefaultResponseDefaults](SupportedDefaultResponseDefaults.md)
 - [Model.SupportedDefaultResponseDefaultsId](SupportedDefaultResponseDefaultsId.md)
 - [Model.SupportedPaymentTypesCurrencyResponse](SupportedPaymentTypesCurrencyResponse.md)
 - [Model.SupportedPaymentTypesMessage](SupportedPaymentTypesMessage.md)
 - [Model.TokenSwapParams](TokenSwapParams.md)
 - [Model.Transaction](Transaction.md)
 - [Model.TransactionData](TransactionData.md)
 - [Model.TransactionInput](TransactionInput.md)
 - [Model.TransactionInputMetaData](TransactionInputMetaData.md)
 - [Model.TransactionInputSupportedParams](TransactionInputSupportedParams.md)
 - [Model.TransactionInputSupportedParamsPartnerData](TransactionInputSupportedParamsPartnerData.md)
 - [Model.TransactionInputSupportedParamsPartnerDataRedirectUrl](TransactionInputSupportedParamsPartnerDataRedirectUrl.md)
 - [Model.TransactionInputSupportedParamsTheme](TransactionInputSupportedParamsTheme.md)
 - [Model.TransactionInputWallet](TransactionInputWallet.md)
 - [Model.TransactionRequest](TransactionRequest.md)
 - [Model.TransactionResponse](TransactionResponse.md)
 - [Model.TransactionResponseInfo](TransactionResponseInfo.md)
 - [Model.TransactionResponseTx](TransactionResponseTx.md)
 - [Model.TriggerOutput](TriggerOutput.md)
 - [Model.TronInput](TronInput.md)
 - [Model.TronTransactionInput](TronTransactionInput.md)
 - [Model.Tx](Tx.md)
 - [Model.UniswapInput](UniswapInput.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="BearerAuth"></a>
### BearerAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

<a id="OAuth2"></a>
### OAuth2

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: 
  - authorization_code: grants authorization_code

<a id="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

