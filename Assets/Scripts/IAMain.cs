using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAMain : MonoBehaviour
{
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
        attack();
    }
    private void OnTriggerExit(Collider other)
    {
        patrol();
    }

    private void patrol()
    {
        gameObject.GetComponent<IAPatrol>().enabled = true;
        gameObject.GetComponent<IAShip>().enabled = false;
    }
    private void attack()
    {
        gameObject.GetComponent<IAPatrol>().enabled = false;
        gameObject.GetComponent<IAShip>().enabled = true;
    }
}
