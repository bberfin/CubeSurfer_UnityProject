
using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    private Vector3 direction = Vector3.forward;
    public bool isStacked = false;
    private RaycastHit hit;

    public PlayerMoverRunner playerMoverRunner;

    void FixedUpdate()
    {
        if (!isStacked)
            return;

        float coeff = 0.02f;
        Debug.DrawRay(transform.position, direction * coeff, Color.red);

        if (Physics.Raycast(transform.position, direction, out hit, 1f * coeff))
        {
            if (hit.transform.gameObject.CompareTag("Obstacle"))
            {
                PlayerCubeManager.Instance.DropCube(this);
            }

            
            if (hit.transform.gameObject.CompareTag("FinishLine"))
            {
                Debug.Log($"on trigger enter: {hit.transform.gameObject.name}");
                AccessEndPoint();
            }

            if (hit.transform.gameObject.CompareTag("Diamond"))
            {
                Debug.Log($"on trigger enter: {hit.transform.gameObject.name}");
                Destroy(hit.transform.gameObject);
                ScoreScene.Instance.PlayerScore++;
            }

        }
    }


    public void AccessEndPoint()
    {
        GameManager.Instance.ActivateWinUI();
        Debug.Log("win!");

    }

    IEnumerator DecreaseSpeedOfPlayer()
    {
        var yieldReturn = new WaitForEndOfFrame();
        while (true)
        {

        }
    }




}
