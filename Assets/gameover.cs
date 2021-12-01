using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public string MainMenu;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

    }

    public void EndGame()
    {

        SceneManager.LoadScene(MainMenu);
    }
}
