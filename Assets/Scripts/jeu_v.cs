using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jeu_v : MonoBehaviour
{
    public MovingBonusMalus Script;

    //public MovingBonusMalus script;

    public Text affichageMetres;
    public float compteurMetre = 0f;
    private string nom ;
    // Start is called before the first frame update
    void Start()
    {

    }

    public static int finalScore;

    // Update is called once per frame
    void Update()
    {

        compteurMetre = compteurMetre + MovingBonusMalus.multiplicateur * Time.deltaTime ;

        finalScore = Mathf.FloorToInt(compteurMetre);
        if (affichageMetres != null)
        {
            affichageMetres.text = finalScore + " mètres";
        }



    }

    



}


