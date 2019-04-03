using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPatrol : MonoBehaviour
{
    public float speed = 50f;
    public float radius = 50f;
    public float rotation = 0f;
    public GameObject cityCenter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rotation == 360)
        {
            rotation = 0;
        }
        if (Vector3.Distance(cityCenter.transform.position, gameObject.transform.position) > 300.55f)
        {
            gameObject.transform.LookAt(cityCenter.transform.position);
            gameObject.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else
        {
            rotation += radius * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(0, rotation, 0);
            gameObject.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        
    }
}
