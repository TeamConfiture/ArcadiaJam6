using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSky : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.x = 0.02f;
        pos.y = 27.29f;
        pos.z = 40f;

        transform.position = pos;
    }

    float mult;
    // Update is called once per frame
    void Update()
    {

        mult = MovingBonusMalus.multiplicateur;
        Vector3 new_pos = transform.position;
        new_pos.y -= Time.deltaTime * 0.2f * mult;
        transform.position = new_pos;
    }

}
