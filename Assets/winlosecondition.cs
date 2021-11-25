using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlosecondition : MonoBehaviour
{
    
    public void Update()
    {
        int numberofpawn = GameObject.FindGameObjectsWithTag("pawn").Length;

        print(numberofpawn);

        if (numberofpawn == 4)
        {
            //EditorApplication.isPlaying = false;
        }
    }

}