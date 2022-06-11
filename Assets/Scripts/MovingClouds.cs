using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingClouds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mult = 2f;

        Vector2 new_pos = transform.position;
        new_pos.y -= Time.deltaTime * mult;
        new_pos.x += Time.deltaTime * 0.3f;
        transform.position = new_pos;
        //Penser à les supp quand non visible
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
