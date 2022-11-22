using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverController : MonoBehaviour
{
    private float velocityX;

    public float VelocityX { get { return velocityX; } }


    void Update()
    {
        Motion();
    }

    private void Motion()
    {

        /*
        if (Input.GetMouseButtonDown(0))
        {
            velocityX = Input.mousePosition.x;

            Debug.Log("mouse-> one click");
        }
        */

        if (Input.GetMouseButton(0))
        {
            velocityX = Input.GetAxis("Mouse X");

            Debug.Log("mouse-> hold down");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            velocityX = Input.GetAxis("Mouse X");
            Debug.Log("mouse-> release");
        }
    }




}
