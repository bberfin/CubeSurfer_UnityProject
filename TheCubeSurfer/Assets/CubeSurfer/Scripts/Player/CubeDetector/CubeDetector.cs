
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
        float angle = 0;
        DOTween.To(() => PlayerMoverRunner.Velocity, x => angle = x, 0, 1f)
            .OnUpdate(() =>
            {
                Debug.Log("DOTween Update");
            }).OnComplete(() => {
                Debug.Log("On Complete");
                //Effect.gameObject.SetActive(true);

                GameManager.Instance.ActivateWinUI();



            });


    }

    IEnumerator DecreaseSpeedOfPlayer()
    {
        var yieldReturn = new WaitForEndOfFrame();
        while (true)
        {

        }
    }


}
