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


        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Current Selected : " + mySystem.currentSelectedGameObject.name);
            Debug.Log("tot");
        }
    }

    public void TestDestroy()
    {
        Debug.Log("lal");
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("Current Selected : " + mySystem.currentSelectedGameObject.name);
        }
    }


}
