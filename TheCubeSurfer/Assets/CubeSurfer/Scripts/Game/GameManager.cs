using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
    public RectTransform WinUI;
    public RectTransform FailUI;
    public RectTransform NextUI;



    #region Singleton

    public static GameManager Instance;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;

    }

    #endregion



    public void ActivateWinUI()
    {
        WinUI.gameObject.SetActive(true);
    }

    public void ActivateFailUI()
    {
        FailUI.gameObject.SetActive(true);
    }

    public void ActivateNextUI()
    {
        NextUI.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void NextLevel2()
    {
        SceneManager.LoadScene("Scene2");
    }

}
