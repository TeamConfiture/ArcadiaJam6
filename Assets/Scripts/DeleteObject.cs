using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float temps;

    // Update is called once per frame
    void Update()
    {
        temps += Time.deltaTime;


        if (temps > 3)
        {

            Vector3 newPos = transform.position;
            newPos.x = 15;
            newPos.y = 15;
            transform.position = newPos;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
