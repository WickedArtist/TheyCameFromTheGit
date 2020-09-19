using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseUI.activeInHierarchy)
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("settrue");
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseUI.activeInHierarchy)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1f;
            Debug.Log("setfalse");
        }
    }
}
