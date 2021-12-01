using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winlosecondition : MonoBehaviour
{
    public string NextLevel;

    public void Update()
    {
        int numberofpawn = GameObject.FindGameObjectsWithTag("pawn").Length;

        print(numberofpawn);

        if (numberofpawn == 0)
        {
            SceneManager.LoadScene(NextLevel);
        }
    }

}