using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControl : MonoBehaviour

{
    private Vector3 movementVector;

    private Transform thisTransform;

    private Rigidbody body;

    public string horizontalCtrl = "Horizontal_P1";
    public string verticalCtrl = "Vertical_P1";
    public string kickCtrl = "kick_P1";


    private CharacterController characterController;

    public float movementSpeed = 15;

    private float gravity = 40;

    private int score = 0;

    public Text scoreText;

    public GameObject ball;
    public float kickForce = 10;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        updateScore();
    }

    // Update is called once per frame
    void Update()
    {

        movementVector.x = Input.GetAxis(horizontalCtrl) * movementSpeed;
        movementVector.z = Input.GetAxis(verticalCtrl) * movementSpeed;


        movementVector.y -= gravity * Time.deltaTime;

        characterController.Move(movementVector * Time.deltaTime);


    }



    // Gestion des scores
    public void addScore(int newScoreValue)
    {
        score += newScoreValue;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = score.ToString();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ballon")
        {

            if (Input.GetButtonDown(kickCtrl))
            {
                print("TEST");

                Vector3 pushDir = (collision.transform.position - transform.position).normalized;
                collision.rigidbody.AddForce(-pushDir * kickForce, ForceMode.Impulse);
            }
        }
    }
}



