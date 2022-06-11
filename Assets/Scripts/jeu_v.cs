using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jeu_v : MonoBehaviour
{
    
    public Text affichageMetres;
    public float compteurMetre = 0f;
    public float multiplicateur = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        compteurMetre = compteurMetre + multiplicateur * Time.deltaTime;

        int finalScore = Mathf.FloorToInt(compteurMetre);
        if (affichageMetres != null)
        { 
                affichageMetres.text = finalScore + " mètres";
        }

        


    }
}
