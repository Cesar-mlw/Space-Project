using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControl : MonoBehaviour
{
    private float velocity = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovementControls();
    }

    void MovementControls()
    {
        transform.localRotation = Quaternion.Euler(Input.GetAxis("Vertical") * -20, 0, Input.GetAxis("Horizontal")*-20);
        transform.Translate(new Vector3(Time.deltaTime * Input.GetAxis("Horizontal") * velocity, Time.deltaTime * Input.GetAxis("Vertical") * velocity), 0);       
    }
}
