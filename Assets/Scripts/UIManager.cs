using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public int score;
    public TMP_Text scoreTxt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null) instance = this;
        else Destroy(this);

        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int trgtScore)
    {
        score += trgtScore;
        scoreTxt.text = score.ToString();
    }

    public void SubtractScore(int trgtScore)
    {
        score -= trgtScore;
        scoreTxt.text = score.ToString();
    }
}
