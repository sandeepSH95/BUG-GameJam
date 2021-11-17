using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceScore : MonoBehaviour
{
    [SerializeField]
    private InfluenceDetector[] influenceDetectors;
    [SerializeField]
    private int score;
    private int scoreDisplay;
    [SerializeField]
    private TextMesh textDisplay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckSurroundings", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
        
    void CheckSurroundings()
    {
        foreach (InfluenceDetector detector in influenceDetectors)
        {
            score += detector.getInfluence();
            detector.ResetInfluence();
        }

        scoreDisplay += score;
        textDisplay.text = scoreDisplay.ToString();

    }
}
