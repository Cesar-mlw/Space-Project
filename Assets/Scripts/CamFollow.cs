using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject lookatTarget, gotoTarget;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(lookatTarget.transform);
        transform.position = Vector3.Lerp(transform.position, gotoTarget.transform.position, Time.deltaTime * speed);
    }
}
