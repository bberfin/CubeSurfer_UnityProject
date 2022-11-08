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
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isCollect)
            {
                isCollect = true;
                collector.AddCube(gameObject);
            }
        }
    }
}
