using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public GameObject GameoverCanvas;
    public void GameOver()
    {
        GameoverCanvas.SetActive(true);
       
    }
}
