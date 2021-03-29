using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{

    [SerializeField]
    private KeyCode m_PlungerInput;
    [SerializeField]
    private Rigidbody PlungerHead;
    [SerializeField]
    GameObject Coil;

    // Pulls back the Plunger
    private void OnPlungerPulled()
    {
        PlungerHead.AddForce(Vector3.back * 400);
        PlungerHead.AddForce(Vector3.down * 400);
        Coil.GetComponent<CoilSpring>().enabled = false;
    }

    // Releases the Plunger
    private void OnPlungerReleased()
    {
        Coil.GetComponent<CoilSpring>().enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlungerHead = GetComponent<Rigidbody>();
        Coil = GameObject.Find("SpringTop");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(m_PlungerInput))
        {
            OnPlungerPulled();
        }

        if (Input.GetKeyUp(m_PlungerInput))
        {
            OnPlungerReleased();
        }
    }
}
