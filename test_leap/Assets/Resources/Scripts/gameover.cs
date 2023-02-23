using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gameoverPanel;

    void Start()
    {
        //gameoverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        if (gameoverPanel.activeSelf)
        {
            SceneManager.LoadScene(0);
        }
    }
}
