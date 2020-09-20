using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    public Collider2D ball;
    public Collider2D player1ground;
    public Collider2D player2ground;


    public Text txtp1score;
    public Text txtp2score;

    private bool resolvingScore = false;

    // Update is called once per frame
    void Update()
    {


        if (ball.IsTouching(player1ground))
        {
            Debug.Log("Player scored");
            resolvingScore = true;
        }

        if (resolvingScore == true)
        {
            ball.
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }


}
