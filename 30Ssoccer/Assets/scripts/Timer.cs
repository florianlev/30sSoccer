using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public Text timerText;
    public float timeLeft = 30f;
    GameObject J1;
    GameObject J2;
    GameObject ball;

    private void Start()
    {
        J1 = GameObject.FindWithTag("But1");

        J2 = GameObject.FindWithTag("But2");
        ball = GameObject.FindWithTag("ballon");
    }
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = timeLeft.ToString();
        if (timeLeft < 0)
        {
            StartCoroutine(ReplaceGame());
        }
    }

    IEnumerator ReplaceGame()
    {
        yield return new WaitForSeconds(3);
        J1.transform.position = new Vector3(-10, J1.transform.position.y);
        J2.transform.position = new Vector3(10, J2.transform.position.y);
        ball.transform.position = new Vector3(0, ball.transform.position.y);
        timeLeft = 30f;
    }
}
