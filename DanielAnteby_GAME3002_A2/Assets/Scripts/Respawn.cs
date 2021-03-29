using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform ball;
    [SerializeField]
    private Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        ball.transform.position = spawnPoint.transform.position;
    }
}
