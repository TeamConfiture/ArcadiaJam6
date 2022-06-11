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
                affichageMetres.text = finalScore + " m�tres";
        }

        


    }

    void Affichage(Text zoneTexte)
    {
        if (finalScore < 250)
        {
            zoneTexte.text = "Apr�s avoir parcouru " + finalScore + " m�tres, tu d�cides finalement de t'arr�ter dans l'Au Del�, histoire jouer � la belote sur les nuages avec les oiseaux.";
        }
        else
        {
            zoneTexte.text = "Tu as d�cid�.e de profiter de ta mort pour aller visiter l'infini plut�t que l'Au-Del�, et apr�s avoir parcouru " + finalScore + " m�tres, tu profites de l'apesanteur et du vide spatial.";
        }
    }

}


