using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAShip : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * Time.deltaTime * 45);
    }

    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject, 0.25f);
    }
}
