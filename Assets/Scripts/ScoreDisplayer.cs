using UnityEngine;
using UnityEngine.UI; 

public class ScoreDisplayer : MonoBehaviour
{
    private int TMPro = 0;
    private Text Score;
    private int awake; 
    public void SetScore(int score)
    {
        TMPro = 0;
        GameObject TextMeshPro = gameObject;
        Score.GetComponent<Text>();

    }

    private void Awake()
    {
        
    }
   
    public void changeScore(int TMProChange)
    {
        TMPro += TMProChange;
        DisplayScore();
    }

    private void DisplayScore()
    {
        Score.text = "Score" + TMPro;
    } 


}
