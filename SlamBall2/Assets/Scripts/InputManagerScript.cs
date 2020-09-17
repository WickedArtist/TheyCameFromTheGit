using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerScript : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public PlayerInputManager inputManager;


    private void Awake()
    {
        inputManager.onPlayerJoined += ctx => PlayerJoin();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerJoin()
    {
        if (player1 = null)
        {

        }
    }
}
