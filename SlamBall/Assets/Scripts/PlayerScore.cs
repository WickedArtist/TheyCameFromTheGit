using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{

    public Collider2D ball;
    public Collider2D player1ground;
    public Collider2D player2ground;


    public int intp1Score = 0;

    // Update is called once per frame
    void Update()
    {
        if (ball.IsTouching(player1ground))
        {
            Debug.Log("Player scored");
        }
        


    }




}
