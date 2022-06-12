using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovingBonusMalus : MonoBehaviour
{


    public string nom = "";
    public static float multiplicateur = 2f;

    //public GameObject EnvoyerMessage;

    public EventSystem mySystem;

    


    public void TestDestroy()
    {

        nom = mySystem.currentSelectedGameObject.name;

        nom = nom.Substring(0, 5);
        if (nom == "Bonus")
        {
            multiplicateur = multiplicateur * 1.2f;
        }
        else if (nom == "Malus")
        {
            multiplicateur = multiplicateur * 0.8f;
        }

        Destroy(mySystem.currentSelectedGameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
