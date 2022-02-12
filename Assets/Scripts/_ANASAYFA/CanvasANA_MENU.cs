using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasANA_MENU : MonoBehaviour
{
    [SerializeField] GameObject buttonlar;
    private void Awake()
    {
        double a =System. Convert.ToDouble(Screen.height) / System.Convert.ToDouble(Screen.width);
        if (1.5f > a) buttonlar.transform.localScale = new Vector3(0.6f, 0.6f, 0.5f);
        else buttonlar.transform.localScale = Vector3.one;
    }
}
