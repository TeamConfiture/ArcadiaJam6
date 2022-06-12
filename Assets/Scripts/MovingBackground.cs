using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    //public GameObject background;
    //public GameObject cimetiere;
    //private jeu_v jeu_script;
    // Start is called before the first frame update
    void Start()
    {
        /*Vector3 pos = transform.position;
        pos.x = 0.02f;
        pos.y = 2.57f;
        pos.z = 5f;
        transform.position = pos;*/
    }


    float mult;
    // Update is called once per frame
    void Update()
    {

        mult = MovingBonusMalus.multiplicateur;
        //jeu_script = cimetiere.GetComponent<multiplicateur>();

        Vector3 new_pos = transform.position;
        new_pos.y -= Time.deltaTime * mult;
        transform.position = new_pos;
    }



}
