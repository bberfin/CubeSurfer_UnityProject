using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScene : MonoBehaviour
{

    public TextMeshProUGUI Txt_score;
    public static ScoreScene Instance;

    public float PlayerScore
    {
        get
        {
            return PlayerPrefs.GetFloat("Score", 1f);
        }
        set
        {
            PlayerPrefs.SetFloat("Score", value);
            Txt_score.text = value.ToString();
        }
    }


    // Start is called before the first frame update
    private void Start()
    {
        PlayerScore = 1f;
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

}
