using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScored : MonoBehaviour
{

    private Rigidbody2D rbd2;
    public Text p1scoreText;
    public Text p2scoreText;
    float duration = 3f;
    float gravity = 1f;

    int intp2score = 0;
    int intp1score = 0;
    string strp1score;
    string strp2score;


    void Start()
    {
        rbd2 = GetComponent<Rigidbody2D>();
        intp2score = int.Parse(p2scoreText.text);
    }

    IEnumerator ResetBall()
    {
        transform.position = new Vector2(-10f, 6.46f);
        rbd2.velocity = Vector2.zero;
        rbd2.angularVelocity = 0f;
        rbd2.gravityScale = 0f;
        yield return new WaitForSeconds(duration);
        rbd2.gravityScale = gravity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1Side")
        {
            Debug.Log("Player 2 Has Scored");
            
            intp2score++;
            strp2score = intp2score.ToString();
            p1scoreText.text = strp2score;
            StartCoroutine( ResetBall() );
        }

        else if (collision.gameObject.name == "Player2Side")
        {
            Debug.Log("Player 1 Has Scored");
            intp1score = int.Parse(p1scoreText.text);
        }

    }


}
