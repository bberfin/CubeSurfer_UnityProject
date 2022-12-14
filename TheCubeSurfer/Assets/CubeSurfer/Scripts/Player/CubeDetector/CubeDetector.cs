
using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{

    public GameObject CubeCollectEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Debug.Log($"Cube {collision.gameObject.name}");

            var cubeBehaviour = collision.gameObject.GetComponent<CubeBehaviour>();

            if (!cubeBehaviour.isStacked)
            {

                Instantiate(CubeCollectEffect, collision.gameObject.transform.position, Quaternion.identity);

                PlayerCubeManager.Instance.GetCube(cubeBehaviour);



            }
        }


    }



}
