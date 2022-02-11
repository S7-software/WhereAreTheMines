using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SahneGecis());
    }
    IEnumerator SahneGecis()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Ana Menu");
    }
}
