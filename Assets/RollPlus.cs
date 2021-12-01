using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RollPlus : MonoBehaviour
{
    public int speed = 300;
    bool isMoving = false;

    [SerializeField]
    private ReportTerrainCollision upCollider, downCollider, leftCollider, rightCollider;

    private Vector3[] directions = new[] { Vector3.forward, Vector3.back, Vector3.left, Vector3.right };

    [Header("Paticle System")]
    public ParticleSystem PlayerDeath;

    public GameObject GameoverCanvas;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            ParticleSystem particle = Instantiate(PlayerDeath, transform.position, Quaternion.identity);
            particle.Play();
            Destroy(gameObject);
            GameOver();

            //SceneManager.LoadScene("Main Menu");
            print("ENTER");

        }
    }

    public void GameOver()
    {
        GameoverCanvas.SetActive(true);

    }

    void Update()
    {

        if (isMoving)
        {
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && leftCollider.getCollisionStatus() == false)
        {
            StartCoroutine(Roll(Vector3.left));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && rightCollider.getCollisionStatus() == false)
        {
            StartCoroutine(Roll(Vector3.right));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && downCollider.getCollisionStatus() == false)
        {
            StartCoroutine(Roll(Vector3.back));
        }
        else if (Input.GetKey(KeyCode.UpArrow) && upCollider.getCollisionStatus() == false)
        {
            StartCoroutine(Roll(Vector3.forward));
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
