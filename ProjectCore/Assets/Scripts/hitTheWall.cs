using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitTheWall : MonoBehaviour
{

    private RaycastHit hit;
    private Vector3 direction = Vector3.forward;


    // Update is called once per frame
    void FixedUpdate()
    {
        SetRaycast();
    }

    private void SetRaycast()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 0.07f))
        {
            if (hit.transform.name == "wallRed")
            {
                Debug.Log("FAILLLLLLLL");
            }
        }
    }

}
