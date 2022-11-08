using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTracker : MonoBehaviour
{
    public GameObject mainCube;
    private Vector3 distance;
    private Vector3 newPosition;
    private Vector3 newPoint;

    [SerializeField] private float lerpValue;

    void Start()
    {
        distance = this.transform.position - mainCube.transform.position;
    }

    void LateUpdate()
    {
        SetCameraTracker();
    }

    private void SetCameraTracker()
    {
        newPoint = new Vector3(0f, mainCube.transform.position.y, mainCube.transform.position.z);
        newPosition = Vector3.Lerp(transform.position,  newPoint+distance, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
