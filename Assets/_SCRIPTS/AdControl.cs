using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AdControl : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public static AdControl instance;
    string gameId = "4609425";
    string placementIdBanner = "bannerWhereAreTheMines";
    string placementIdOdul = "odulWhereAreTheMines";
    bool testMode = false;
    private void Awake()
    {


        if (FindObjectsOfType<AdControl>().Length > 1 )
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        

    }
    void Start()
    {
        if (!KAYIT.GetReklamVar()) return;
        Advertisement.Initialize(gameId, testMode);


    }
    public void ShowRewardedVideoMayinAra()
    {
        if (!KAYIT.GetReklamVar())
        {
            OyunKontrol.instance.HandleAds();
            return;
        }
        Advertisement.Show(placementIdOdul, instance);
    }

    public void ShowBanner()
    {
        if (!KAYIT.GetReklamVar()) return;
        StartCoroutine(ShowBannerWhenReady());
    }

    public void CloseBanner()
    {
        if (!KAYIT.GetReklamVar()) return;
        Advertisement.Banner.Hide();
    }

    IEnumerator ShowBannerWhenReady()
    {

        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);

        yield return new WaitForSeconds(0f);

        Advertisement.Banner.Show(placementIdBanner);


    }

    public void OnInitializationComplete()
    {

    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {

    }

    public void OnUnityAdsAdLoaded(string placementId)
    {

    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {

    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {


    }

    public void OnUnityAdsShowStart(string placementId)
    {

    }

    public void OnUnityAdsShowClick(string placementId)
    {

    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {

        switch (showCompletionState)
        {
            case UnityAdsShowCompletionState.SKIPPED:
                Clock.instance._durakla = false;
                break;
            case UnityAdsShowCompletionState.COMPLETED:
                if (placementId == placementIdOdul)
                {
                    OyunKontrol.instance.HandleAds();
                }
                break;
            case UnityAdsShowCompletionState.UNKNOWN:
                Clock.instance._durakla = false;
                break;
            default:
                break;
        }
    }
}
