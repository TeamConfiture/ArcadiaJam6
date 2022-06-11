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

    int finalScore;

    // Update is called once per frame
    void Update()
    {
        
        compteurMetre = compteurMetre + multiplicateur * Time.deltaTime;

        finalScore = Mathf.FloorToInt(compteurMetre);
        if (affichageMetres != null)
        { 
                affichageMetres.text = finalScore + " mètres";
        }

        


    }

    void Affichage(Text zoneTexte)
    {
        if (finalScore < 250)
        {
            zoneTexte.text = "Après avoir parcouru " + finalScore + " mètres, tu décides finalement de t'arrêter dans l'Au Delà, histoire jouer à la belote sur les nuages avec les oiseaux.";
        }
        else
        {
            zoneTexte.text = "Tu as décidé.e de profiter de ta mort pour aller visiter l'infini plutôt que l'Au-Delà, et après avoir parcouru " + finalScore + " mètres, tu profites de l'apesanteur et du vide spatial.";
        }
    }

}


