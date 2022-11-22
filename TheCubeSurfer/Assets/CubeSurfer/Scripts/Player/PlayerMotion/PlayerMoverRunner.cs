
using DG.Tweening;
using System.Collections;
using UnityEngine;

public class PlayerMoverRunner : MonoBehaviour
{


    [SerializeField]
    private PlayerMoverController playerMoverController;
    [SerializeField]
    public float Velocity;


    [SerializeField]
    private float horizontalSpeed;
    [SerializeField]
    private float LimitX;
    [SerializeField]
    private float LimitY;

    private float newPositionX;



    private void FixedUpdate()
    {
        goForward();
        goHorizontal();
    }


    private void goForward()
    {
        transform.Translate(Vector3.forward * Velocity * Time.deltaTime);
    }

    private void goHorizontal()
    {
        newPositionX = transform.position.x + playerMoverController.VelocityX * horizontalSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, LimitY, LimitX);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }





}
