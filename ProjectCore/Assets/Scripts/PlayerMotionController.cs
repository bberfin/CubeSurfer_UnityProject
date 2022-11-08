using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotionController : MonoBehaviour
{


    [SerializeField]
    private PlayerMotion playerMotion;
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float horizontalSpeed;
    [SerializeField]
    private float LimitX;
    [SerializeField]
    private float LimitY;

    private float newPositionX;

    void FixedUpdate()
    {
        goForward();
        goHorizontal();
    }

    private void goForward()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
    }

    private void goHorizontal()
    {
        newPositionX = transform.position.x + playerMotion.VelocityX * horizontalSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, LimitY, LimitX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

}
