using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;
public class Ad_Manager : MonoBehaviour {

	public static Ad_Manager Instance { get; set; }
    public string Banner_id;
    public string interstitial_id;

    

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        

      
#if UNITY_EDITOR
#elif UNITY_ANDROID

        Admob.Instance().initAdmob(Banner_id,interstitial_id);
       // Admob.Instance().loadRewardedVideo("ca-app-pub-3800355237509207/1762562834");
        Admob.Instance().setTesting(true); //Test amaçlı reklamlar
        Admob.Instance().loadInterstitial(); //Geçiş reklamı yüklemi.
#endif

    }

    public void Show_Banner_top()
    {
      
#if UNITY_EDITOR
#elif UNITY_ANDROID

        Admob.Instance().showBannerRelative(AdSize.SmartBanner, AdPosition.TOP_CENTER,0);
#endif
    }
    public void Show_Banner_bot()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID

        Admob.Instance().showBannerRelative(AdSize.SmartBanner, AdPosition.BOTTOM_CENTER,0);
#endif
    }

    public void Show_Video()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID

        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
            Admob.Instance().loadInterstitial();
        }
#endif

    }

    public void Remove_Banner()
    {

        
#if UNITY_EDITOR
#elif UNITY_ANDROID
        Admob.Instance().removeAllBanner();
#endif
    }

    public void Show_Rewarted()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID
        if(Admob.Instance().isRewardedVideoReady())
        {
            Admob.Instance().showRewardedVideo();
            
        }
#endif

    }
}
