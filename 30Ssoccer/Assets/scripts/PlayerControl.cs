using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControl : MonoBehaviour

{
    private Vector3 movementVector;

    private Transform thisTransform;

    public string horizontalCtrl = "Horizontal_P1";
    public string verticalCtrl = "Vertical_P1";

    private CharacterController characterController;

    public float movementSpeed = 15;

    private float gravity = 40;

    private int score = 0;

    public Text scoreText;

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
        scoreText.text =score.ToString();
    }
}
