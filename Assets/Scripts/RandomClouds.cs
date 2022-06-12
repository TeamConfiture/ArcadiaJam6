using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClouds : MonoBehaviour
{
    public GameObject[] clouds;
    public GameObject starS;
    public GameObject starM;
    public GameObject starL;
    public GameObject[] planets;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (jeu_v.finalScore < 300)
        {
            float randNumber = Random.Range(0, 1000);
            if (randNumber > 998)
            {
                int randomIndex = Random.Range(0, clouds.Length);
                Vector2 randomSpawnPosition = new Vector2(Random.Range(-15, 11), 7);

                Instantiate(clouds[randomIndex], randomSpawnPosition, Quaternion.identity);
            }
        }

        if (jeu_v.finalScore > 200)
        {
            float randNumber2 = Random.Range(0, 500);
            if (randNumber2 > 375)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 11), 7, 37);

                Instantiate(starS, randomSpawnPosition, Quaternion.identity);
            }
            else if (randNumber2 > 320)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 11), 7, 37);

                Instantiate(starM, randomSpawnPosition, Quaternion.identity);
            }
            else if (randNumber2 > 310)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 11), 7, 37);

                Instantiate(starL, randomSpawnPosition, Quaternion.identity);
            }

            float randNumber3 = Random.Range(0, 1000);
            if (randNumber3 == 42)
            {
                int randomIndex = Random.Range(0, planets.Length);
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 11), 7, 38);

                Instantiate(planets[randomIndex], randomSpawnPosition, Quaternion.identity);
            }
        }



    }


    

}
