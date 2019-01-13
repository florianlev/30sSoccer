using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonControl : MonoBehaviour
{
    // Start is called before the first frame update

    public int scoreValue = 1;

    private PlayerControl playerControl;

    void Start()
    {
    }

    void OnTriggerEnter(Collider collision)
    {

        Debug.Log("COLLISION");
        if (collision.gameObject.name == "But2")
        {
            GameObject playerControlObject = GameObject.FindWithTag("But2");
            playerControl = playerControlObject.GetComponent<PlayerControl>();
            playerControl.addScore(scoreValue);

        }
        else if (collision.gameObject.name == "But1")
        {
            GameObject playerControlObject = GameObject.FindWithTag("But1");
            playerControl = playerControlObject.GetComponent<PlayerControl>();
            playerControl.addScore(scoreValue);

        }
    }
}
