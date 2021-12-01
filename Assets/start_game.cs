using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game : MonoBehaviour
{
    public string Destination;

    public void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(Destination);
        }
    }
}
