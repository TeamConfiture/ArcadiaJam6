using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject[] bonusMalus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randNumber = Random.Range(0, 1000);
        if (randNumber > 998)
        {
            int randomIndex = Random.Range(0, bonusMalus.Length);
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-8, 8), Random.Range(-4, 4));

            Instantiate(bonusMalus[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}
