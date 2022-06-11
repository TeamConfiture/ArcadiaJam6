using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovingBonusMalus : MonoBehaviour
{



    private float temps = 0;

    //public Camera cam = Camera.main;
    //private float cHeight;
    //private float cWidth;
    public Canvas canvas;


    void Start()
    {
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
            //Debug.Log("Current Selected : " + mySystem.currentSelectedGameObject.name);

            /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10000.0f) && hit.transform.gameObject != null)
            {
                // here you need to insert a check if the object is really a tree
                // for example by tagging all trees with "Tree" and checking hit.transform.tag
                GameObject.Destroy(hit.transform.gameObject);
            }*/
            




            //Debug.Log("Monde : " + cHeight + " ; " + cWidth);
            Vector2 mousePos = Input.mousePosition;
            mousePos.x = mousePos.x / canvas.GetComponent<RectTransform>().rect.width*17f - 8.75f;
            mousePos.y = mousePos.y / canvas.GetComponent<RectTransform>().rect.height * 11f - 5.25f;

            Vector2 pos = transform.position;

            if (pos.x < mousePos.x + 1.5f && pos.x < mousePos.x - 1.5f && pos.y < mousePos.y + 1.5f && pos.y > mousePos.y - 1.5f)
            {
                Debug.Log("Oui");
            }
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
