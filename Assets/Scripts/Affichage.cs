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
            zoneTexte.text = "Apr�s avoir parcouru " + score + " m�tres, tu d�cides finalement de t'arr�ter dans l'Au Del�, histoire jouer � la belote sur les nuages avec les oiseaux.";
        }
        else
        {
            zoneTexte.text = "Tu as d�cid�.e de profiter de ta mort pour aller visiter l'infini plut�t que l'Au-Del�, et apr�s avoir parcouru " + score + " m�tres, tu profites de l'apesanteur et du vide spatial.";
        }
    }
}
