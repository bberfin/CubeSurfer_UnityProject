using DG.Tweening;
using System.Collections;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public Animator animatorOfPlayer;

    public PlayerMoverRunner playerMoverRunner;

    private void Awake()
    {
        Singleton();
    }

    #region Singleton

    public static PlayerBehaviour Instance;

    private void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }

    #endregion

    public void VictoryAnimation()
    {
        animatorOfPlayer.SetTrigger("Victory");
    }

    public void FailAnimation()
    {
        animatorOfPlayer.SetTrigger("Fail");
    }

    public void StopPlayer()
    {
        DOTween.To(() => playerMoverRunner.Velocity, x => playerMoverRunner.Velocity = x, 0, 0.003f);
    }

    public void SlowDownPlayer()
    {
        DOTween.To(() => playerMoverRunner.Velocity, x => playerMoverRunner.Velocity = x, 0, 1.5f).OnUpdate(() => {
            Debug.Log("DOTween Update");           
        }).OnComplete(() => {
            Debug.Log("On Complete");
        });
    }


}
