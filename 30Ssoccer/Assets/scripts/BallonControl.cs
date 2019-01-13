using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class BallonControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int scoreValue = 1;

    private PlayerControl playerControl;
    private GameObject J1;
    private GameObject J2;


    void Start()
    {
        J1 = GameObject.FindWithTag("But1");

        J2 = GameObject.FindWithTag("But2");
    }

    void OnTriggerEnter(Collider collision)
    {

        Debug.Log("COLLISION");
        GameObject playerControlObject = GameObject.FindWithTag(collision.gameObject.name);
        playerControl = playerControlObject.GetComponent<PlayerControl>();

        if (collision.gameObject.name == "But2")
        {
            playerControl.addScore(scoreValue);

        }
        else if (collision.gameObject.name == "But1")
        {
            playerControl.addScore(scoreValue);

        }
        StartCoroutine(replaceGame());
    }

    IEnumerator replaceGame()
    {

        yield return new WaitForSeconds(3);
        J1.transform.position= new Vector3(-10, J1.transform.position.y);
        J2.transform.position = new Vector3(10, J2.transform.position.y);


    }
}
