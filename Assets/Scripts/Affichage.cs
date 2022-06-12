using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Affichage : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame

    public Text zoneTexte;
    private int score = jeu_v.finalScore;
    void Update()
    {
        if (jeu_v.finalScore < 250)
        {
            zoneTexte.text = "Après avoir parcouru " + score + " mètres, tu décides finalement de t'arrêter dans l'Au Delà, histoire jouer à la belote sur les nuages avec les oiseaux.";
        }
        else
        {
            zoneTexte.text = "Tu as décidé.e de profiter de ta mort pour aller visiter l'infini plutôt que l'Au-Delà, et après avoir parcouru " + score + " mètres, tu profites de l'apesanteur et du vide spatial.";
        }
    }
}
