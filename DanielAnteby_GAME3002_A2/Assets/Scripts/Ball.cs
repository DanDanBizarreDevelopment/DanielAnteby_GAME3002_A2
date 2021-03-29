using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    GameManager gameManager;
    public GameObject Pinball;
    private Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        Pinball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ImpactPoint")
        {
            gameManager.ImpactPointHit();

        }
    }
}
