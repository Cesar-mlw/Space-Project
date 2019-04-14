using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControl : MonoBehaviour
{
    private float velocity = 10f;
    public GameObject shipMesh;
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
        shipMesh.transform.localRotation = Quaternion.Euler(Input.GetAxis("Vertical") * -20,
                                                                Input.GetAxis("Horizontal") * 15,
                                                                Input.GetAxis("Horizontal") * -20);
        transform.Translate(new Vector3(Time.deltaTime * Input.GetAxis("Horizontal") * velocity,
                                            0),
                                            0);
    }
}
