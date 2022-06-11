using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject bonus;
    public GameObject malus;
    public GameObject canvasObject;
    private float cHeight;
    private float cWidth;

    // Start is called before the first frame update
    void Start()
    {
        cHeight = canvasObject.transform.GetComponent<RectTransform>().rect.height;
        cWidth = canvasObject.transform.GetComponent<RectTransform>().rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        float randNumber = Random.Range(0, 2000);
        if (randNumber == 997)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-1*cWidth/2 +10 , cWidth/2 -10), Random.Range(-1 * cHeight / 2 -10, cHeight / 2 +10), -1200);

            GameObject newBonus = Instantiate(bonus, randomSpawnPosition, Quaternion.identity) as GameObject;
            newBonus.transform.SetParent(GameObject.FindGameObjectWithTag("InCanvas").transform, false);
        }
        if (randNumber == 999)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-1 * cWidth / 2 +10 , cWidth / 2 - 10), Random.Range(-1 * cHeight / 2 - 10, cHeight / 2 + 10), -1200);

            //Instantiate(malus, randomSpawnPosition, Quaternion.identity);
            GameObject newMalus = Instantiate(malus, randomSpawnPosition, Quaternion.identity) as GameObject;
            newMalus.transform.SetParent(GameObject.FindGameObjectWithTag("InCanvas").transform, false);
        }
    }
}
