using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScene : MonoBehaviour
{

    public TextMeshProUGUI Txt_score;
    public TextMeshProUGUI Txt_cubes;
    public static ScoreScene Instance;

    public float Cubes
    {
        get
        {
            return PlayerPrefs.GetFloat("Cubes", 1f);
        }
        set
        {
            PlayerPrefs.SetFloat("Cubes", value);
            Txt_cubes.text = value.ToString();
        }
    }

    public float PlayerScore
    {
        get
        {
            return PlayerPrefs.GetFloat("Score", 1f);
        }
        set
        {
            PlayerPrefs.SetFloat("Score", value);
            Txt_score.text =value.ToString();
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        Cubes = 1f;
        PlayerScore = 0f;
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
