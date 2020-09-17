using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Player1Side")
        {
            UI.GetComponentInChildren<Player2ScoreScript>().AddScore();
            UI.GetComponentInChildren<Player2ScoreScript>().UpdateScoreText();
        }
        else if (collision.collider.name == "Player2Side")
        {
            UI.GetComponentInChildren<Player1ScoreScript>().AddScore();
            UI.GetComponentInChildren<Player1ScoreScript>().UpdateScoreText();
        }
    }
}
