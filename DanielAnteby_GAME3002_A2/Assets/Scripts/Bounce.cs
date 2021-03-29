using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    float power = 1500;
    GameObject pushBack;

    //Push ball with explosive force on collision with active bumper/bash toy
    private void OnCollisionEnter(Collision collision)
    {
        pushBack.GetComponent<Rigidbody>().AddExplosionForce(power, this.transform.position, 5);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        pushBack = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
