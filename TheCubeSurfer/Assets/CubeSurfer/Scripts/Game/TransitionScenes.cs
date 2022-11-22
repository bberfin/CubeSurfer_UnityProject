using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class TransitionScenes : MonoBehaviour
{


    public RectTransform MenuUI;
    public RectTransform InformUI;   
    
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }


    public void ActivateInformUI()
    {
        MenuUI.gameObject.SetActive(false);
        InformUI.gameObject.SetActive(true);
    }

    public void DeActivateInformUI()
    {
        MenuUI.gameObject.SetActive(true);
        InformUI.gameObject.SetActive(false);
    }

}
