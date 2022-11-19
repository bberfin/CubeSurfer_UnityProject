
using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CubeDetector : MonoBehaviour
{
    public PlayerMoverRunner PlayerMoverRunner;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Debug.Log($"Cube {collision.gameObject.name}");

            var cubeBehaviour = collision.gameObject.GetComponent<CubeBehaviour>();

            if (!cubeBehaviour.isStacked)
            {
                PlayerCubeManager.Instance.GetCube(cubeBehaviour);
            }
        }


    }


    public void AccessEndPoint()
    {

      
    }




}
