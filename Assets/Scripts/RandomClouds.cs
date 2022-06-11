using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClouds : MonoBehaviour
{
    public GameObject[] clouds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float randNumber = Random.Range(0,1000);
        if (randNumber > 998)
        {
            int randomIndex = Random.Range(0, clouds.Length);
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-15, 11), 7);

            Instantiate(clouds[randomIndex], randomSpawnPosition, Quaternion.identity);
        }

        
    }

    void createCloud()
    {

        //jeu_script = cimetiere.GetComponent<multiplicateur>();

        
    }

    

}
