using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarMissile : MonoBehaviour
{
    public Missile[] missiles;
    int index = 0;
    GameObject lastTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if(lastTarget != null)
            {
                missiles[index].SetTarget(lastTarget);
            }
            else
            {
                missiles[index].SetTarget();
            }
            index++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            lastTarget = other.gameObject;
            print(other.gameObject.name);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            lastTarget = null;
        }
        
    }
}
