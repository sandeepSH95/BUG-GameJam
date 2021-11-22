using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    public int speed = 300;
    bool isMoving = false;
    bool movingStarted = false;

    //public Material dissolver;

    private void Start()
    {
        if (!movingStarted)
        {
            //dissolver.SetFloat("AlphaClip", 1);
        }
    }

    void Update() {

        if (movingStarted){
            if (isMoving)
            {
                //dissolver.SetFloat("AlphaClip", Mathf.Lerp(1, 0, Time.deltaTime * 90));
                //dissolver.SetFloat("Vector1_be3dc4a8bafa438e81f5f78631688d8b", Mathf.Lerp(2, 1, 1));   
                // dissolver.SetFloat("BOOLEAN_E78A83844EA143DEB611A61F33BB2ESA", 1);
                return;

            }

            if (!isMoving){
                //dissolver.SetFloat("AlphaClip", Mathf.Lerp(1, 2, Time.deltaTime));
                //dissolver.SetFloat("Vector1_be3dc4a8bafa438e81f5f78631688d8b", Mathf.Lerp(1, 2, 1));
                //dissolver.SetFloat("BOOLEAN_E78A83844EA143DEB611A61F33BB2ESA", 0);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            StartCoroutine(Roll(Vector3.right));
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            StartCoroutine(Roll(Vector3.left));
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            StartCoroutine(Roll(Vector3.forward));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            StartCoroutine(Roll(Vector3.back));
        }

    }

    IEnumerator Roll(Vector3 direction) {
        isMoving = true;
        movingStarted = true;

        float remainingAngle = 90;
        Vector3 rotationCenter = transform.position + direction / 2 + Vector3.down / 2;
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, direction);

        while (remainingAngle > 0) {
            float rotationAngle = Mathf.Min(Time.deltaTime * speed, remainingAngle);
            transform.RotateAround(rotationCenter, rotationAxis, rotationAngle);
            remainingAngle -= rotationAngle;
            yield return null;
        }

        //dissolver.SetFloat("AlphaClip", 2);
        isMoving = false;
    }
}
