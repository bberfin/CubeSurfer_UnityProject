
using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    private Vector3 direction = Vector3.forward;
    public bool isStacked = false;
    private RaycastHit hit;




    
    AudioSource audioSource;


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
                audioSource = hit.transform.gameObject.GetComponent<AudioSource>();
                audioSource.Play();
                PlayerCubeManager.Instance.DropCube(this);
            }

            if (hit.transform.gameObject.CompareTag("Diamond"))
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.Play();
                Debug.Log($"on trigger enter: {hit.transform.gameObject.name}");  
                Destroy(hit.transform.gameObject);
                ScoreScene.Instance.PlayerScore++;
                
            }

            
            if (hit.transform.gameObject.CompareTag("EndOfLevel"))
            {
                Debug.Log($"on trigger enter: {hit.transform.gameObject.name}");
                AccessNextLevelEndPoint();
            }
            

            if (hit.transform.gameObject.CompareTag("FinishLine"))
            {
                Debug.Log($"on trigger enter: {hit.transform.gameObject.name}");
                AccessEndPoint();
            }

        }
    }


    public void AccessNextLevelEndPoint()
    {
        PlayerBehaviour.Instance.VictoryAnimation();
        //GameManager.Instance.ActivateNextUI();
        Debug.Log("next level!");




    }

    public void AccessEndPoint()
    {
        PlayerBehaviour.Instance.VictoryAnimation();
       // GameManager.Instance.ActivateWinUI();
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
