using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject finishGO;

    Image progressBar;
    float maxDistance;

    void Start()
    {
        progressBar = GetComponent<Image>();
        maxDistance = finishGO.transform.position.z ;

        progressBar.fillAmount = (playerGO.transform.position.z - 7.914f ) / (maxDistance - 7.914f);
       // Debug.Log("START : " + playerGO.transform.position.z);

    }


    void Update()
    {
        if(progressBar.fillAmount < 1)
        {
            progressBar.fillAmount = (playerGO.transform.position.z - 7.914f) / (maxDistance - 7.914f);
            // Debug.Log("UPDATE : " + playerGO.transform.position.z);
        }
        
    }
}
