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
    [SerializeField] Image yildiz0, yildiz1, yildiz2;

    Color renkBeyazSeffaf = new Color(255, 255, 255, 0.12f);
    Color renkBeyaz = new Color(255, 255, 255, 255);

    private void Awake()
    {
        double a = System.Convert.ToDouble(Screen.height) / System.Convert.ToDouble(Screen.width);
        if (1.5f > a) gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        else gameObject.transform.localScale = Vector3.one;
    }
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

    public void SetYildiz(int yildizSayisi)
    {
        yildiz0.color = yildizSayisi >= 1 ? renkBeyaz : renkBeyazSeffaf;
        yildiz1.color = yildizSayisi >= 2 ? renkBeyaz : renkBeyazSeffaf;
        yildiz2.color = yildizSayisi >= 3 ? renkBeyaz : renkBeyazSeffaf;

    }
}
