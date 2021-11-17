using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmovement : MonoBehaviour
{
    [SerializeField]
    private GameObject colliderObject;
    [SerializeField]
    private int speed = 300;
    private bool isMoving = false;
    //I know it's inelegant but the order of the array must be: up, down, left, right ; To match the directions
    [SerializeField]
    private ReportCollision[] NPCColliderObjects;
    private Vector3[] directions = new[] { Vector3.forward, Vector3.back, Vector3.left, Vector3.right };
    int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == false)
        {
            index = Random.Range(0, directions.Length);
            if (NPCColliderObjects[index].getCollisionStatus() == false)
            {

                StartCoroutine(Roll(directions[index]));
            }
            
        }

    }

    IEnumerator Roll(Vector3 direction)
    {
        isMoving = true;

        float remainingAngle = 90;
        Vector3 rotationCenter = transform.position + direction / 2 + Vector3.down / 2;
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, direction);

        while (remainingAngle > 0)
        {
            float rotationAngle = Mathf.Min(Time.deltaTime * speed, remainingAngle);
            transform.RotateAround(rotationCenter, rotationAxis, rotationAngle);
            remainingAngle -= rotationAngle;
            yield return null;
        }

        isMoving = false;
    }
}
