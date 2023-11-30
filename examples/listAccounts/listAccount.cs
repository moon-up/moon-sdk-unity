using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;


public class MoonSDKe : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        UnityEngine.Debug.developerConsoleVisible = true;
        Configuration config = new Configuration();
        config.BasePath = "https://vault-api.usemoon.ai";
        config.AddApiKey("Authorization", "");

        var apiInstance = new AccountsApi(config);
        var authorization = "BearerAuth";

        try
        {
            AccountControllerResponse result = await apiInstance.ListAccountsAsync(authorization);
            UnityEngine.Debug.Log(result.Data);
        }
        catch (ApiException e)
        {
            // Handle exception
            UnityEngine.Debug.LogError("Exception when calling AccountsApi.ListAccounts: " + e.Message);
            UnityEngine.Debug.LogError("Status Code: " + e.ErrorCode);
            UnityEngine.Debug.LogError(e.StackTrace);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
