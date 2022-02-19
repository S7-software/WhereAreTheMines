using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkAyarlar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (!PlayerPrefs.HasKey("dil"))
        {
            if (Application.systemLanguage == SystemLanguage.Turkish)
            {
                KAYIT.SetDil("tr");
            }
            else if (Application.systemLanguage == SystemLanguage.French)
            {
                KAYIT.SetDil("fr");
            }
            else if (Application.systemLanguage == SystemLanguage.Spanish)
            {
                KAYIT.SetDil("es");
            }
            else if (Application.systemLanguage == SystemLanguage.Japanese)
            {
                KAYIT.SetDil("jp");
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                KAYIT.SetDil("de");
            }
            else if (Application.systemLanguage == SystemLanguage.Russian)
            {
                KAYIT.SetDil("ru");
            }
            
            else
            {
                KAYIT.SetDil("en");
            }
        }
        else
        {
            KAYIT.SetDil(KAYIT.GetSistemDili());
        }

        if (!PlayerPrefs.HasKey("ses"))
        {
            PlayerPrefs.SetFloat("ses", 1f);
        }
        
    }

}
