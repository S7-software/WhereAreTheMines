using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
public class IAPManager : MonoBehaviour
{
    [SerializeField] GameObject _goBtnAds;
    public string _keyProduct= "reklam.kaldir";
    private void Awake()
    {
        if (!KAYIT.GetReklamVar())
        {
            _goBtnAds.SetActive(false);
            return;
        }
        
    }

    public void OnPurchaseComplete(Product product)
    {
        if (_keyProduct == product.definition.id)
        {
            Debug.Log("basarili");
            KAYIT.SetReklamVar(false);
            Invoke(nameof(Sifirla), 0.5f);
        }
    }
    public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
    {
        Debug.Log("basarisiz! ");

    }

    private void Sifirla()
    {
        SceneManager.LoadScene(0);
    }


}
