using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship3DControl : MonoBehaviour
{
    public Rigidbody rbd;
    Vector3 inputaxis;
    public TrailRenderer tr, tl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        inputaxis = new Vector3(Input.GetAxis("Vertical") * 10000, 0, -Input.GetAxis("Horizontal") * 40000);

        float trail = Vector3.Angle(transform.forward, rbd.velocity.normalized) * 0.01f;
        tr.time = trail;
        tl.time = trail;

        //adiciona o torque relativo para movimento avionico
        rbd.AddRelativeTorque(inputaxis);
        float roll = Vector3.Angle(transform.right, Vector3.up) - 90;
        rbd.AddTorque(new Vector3(0, roll * 50, 0));
        rbd.AddRelativeForce(new Vector3(0, 0, 80000));
    }
}
