using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovingBonusMalus : MonoBehaviour
{



    private float temps = 0;



    /*public Camera cam = Camera.main;
    private float cHeight;
    private float cWidth;*/



    void Start()
    {
        //cHeight = 2f * cam.orthographicSize;
        //cWidth = cHeight * cam.aspect;
    }



    // Update is called once per frame
    void Update()
    {


        temps += Time.deltaTime;
        if (temps > 5)
        {
            MoveBonusMalus();
        }


        if (Input.GetMouseButtonDown(0))
        {
            /*Debug.Log("Monde : " + cHeight + " ; " + cWidth);
            Debug.Log("Appuie compté");
            Vector2 mousePos = Input.mousePosition;
            Debug.Log("Souris : " + mousePos.x + " ; " + mousePos.y);
            Vector2 pos = transform.position;
            Debug.Log("Objet : " + pos.x + " ; " + pos.y);
            if (pos.x < mousePos.x - 1.5f && pos.x < mousePos.x + 1.5f && pos.y < mousePos.y - 1.5f && pos.y > mousePos.y + 1.5f)
            {
                MoveBonusMalus();
            }*/
        }
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void MoveBonusMalus()
    {
        Vector3 pos = transform.position;
        pos.x = 15f;
        pos.y = 15f;
        pos.z = 0f;

        transform.position = pos;
    }

}
