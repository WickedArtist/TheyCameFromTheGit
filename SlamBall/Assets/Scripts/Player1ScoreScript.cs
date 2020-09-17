using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1ScoreScript : MonoBehaviour
{
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
    }

    public void UpdateScoreText()
    {
        gameObject.GetComponent<Text>().text = score.ToString();
    }

}
