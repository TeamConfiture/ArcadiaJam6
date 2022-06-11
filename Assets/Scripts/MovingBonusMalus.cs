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


    public EventSystem mySystem;

    void Start()
    {
        //cHeight = 2f * cam.orthographicSize;
        //cWidth = cHeight * cam.aspect;
    }

    

    // Update is called once per frame
    void Update()
    {

        temps = +Time.deltaTime;


        if (temps > 5 )
        {
            Destroy(this.gameObject);
            Vector2 newPos = transform.position;
            newPos.x = 15;
            newPos.y = 15;
            transform.position = newPos;
        }
    }

    public void TestDestroy()
    {
        Debug.Log("Clique");
        if (mySystem.currentSelectedGameObject.name == "Bonus(Clone)")
        {
            
        }
        else
        {

        }
        Destroy(mySystem.currentSelectedGameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
