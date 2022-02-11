using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sonuc : MonoBehaviour
{

    [Header("Tanimlanacaklar")]
    public Text txtSonuc1;
    public Text txtSonuc2;
    public Text txtMayin;
    public Text txtSure;
    public Text txtHamle;
    public Text txtMesaj1;
    public Text txtMesaj2;
    public GameObject btnCarpi;


    // Start is called before the first frame update
    private void Start()
    {
        btnCarpi.GetComponent<Button>().onClick.AddListener(Kapat);
    }

    public void Kapat()
    {
        gameObject.SetActive(false);
    }
    public void SetTxtSonuc(string yazi)
    {
        txtSonuc1.text = yazi;
        txtSonuc2.text = yazi;
    }
    public void SetTxtMayin(string yazi)
    {
        txtMayin.text = yazi;
        
    }
    public void SetTxtHamle(string yazi)
    {
        txtHamle.text = yazi;
        
    }
    public void SetTxtSure(string yazi)
    {
        txtSure.text = yazi;
        
    }
    public void SetTxtMesaj(string yazi)
    {
        txtMesaj1.text = yazi;
        txtMesaj2.text = yazi;
        
    }
}
