using UnityEngine;

public class Ads : MonoBehaviour
{
    void Start()
    {
        ShowAd();
    }
    public void ShowAd()
    {
        Application.ExternalCall("ShowAd");
    }
}
