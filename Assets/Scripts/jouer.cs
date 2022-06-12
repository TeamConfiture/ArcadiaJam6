using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jouer : MonoBehaviour
{

    int hauteurFinale = 0 ;


    public void PushPlay(string NomScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(NomScene);
    }

    public void PushAuDela(Text texteARecup)
    {
        hauteurFinale = int.Parse(texteARecup.text.Substring(0, texteARecup.text.Length - 7));
        if(hauteurFinale < 250)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("AuDela");
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("AuDela2");
        }

    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
