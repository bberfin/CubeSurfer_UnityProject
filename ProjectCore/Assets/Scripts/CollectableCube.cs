using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{

    [SerializeField]
    private Collector collector;

    private RaycastHit hit;
    private Vector3 direction = Vector3.back;
    private bool isCollect = false;

    // Start is called before the first frame update
    void Start()
    {
        collector = GameObject.FindObjectOfType<Collector>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetRaycast();
    }
 
        private void SetRaycast()
        {
            if (Physics.Raycast(transform.position, direction, out hit, 0.07f))
            {
                if (!isCollect)
                {
                    isCollect = true;
                    collector.AddCube(gameObject);
                    SetDirection();
                }

            if (hit.transform.name == "wallRed")
                {
                    collector.RemoveCube(gameObject);
                }
            }
        }
  
/*
    private void OnDrawGizmos()
    {
        
        float maxDistance = 0.5f;
        bool isHit = Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.f, out hit, transform.rotation, maxDistance);

        if (isHit)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
            Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.lossyScale);

            if (!isCollect)
            {
                isCollect = true;
                collector.AddCube(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "wallRed")
            {
                collector.RemoveCube(gameObject);
            }
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, transform.forward * maxDistance);

        }
    }

*/
    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
