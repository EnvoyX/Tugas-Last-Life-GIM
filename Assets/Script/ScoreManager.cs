using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager ScoreManagerInstance;
    public int score = 0;
    public TMP_Text scoreText;

    private void Awake()
    {
        ScoreManagerInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickScore(int PointValue){
        score += PointValue;
        if (score < 100){
            scoreText.text = score.ToString() + " clicks";
        }
        else {
            GameHandler.GameHandlerInstance.ResultScreen();
            scoreText.text = 100.ToString() + " clicks";
        }

        
        

    }
}
