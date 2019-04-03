using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public ParticleSystem particlefire;
    public GameObject mycamera;
    public GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        crosshair.transform.forward = mycamera.transform.forward;
        if (Input.GetButtonDown("Fire1"))
        {
            particlefire.Emit(1);
        }
    }
}
