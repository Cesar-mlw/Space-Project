   using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour
{
    float velocity = 50;
    Random random = new Random();
    public ParticleSystem explo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, Time.deltaTime * velocity);
        if(transform.position.z < -50){
            Destroy(gameObject);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        explo.Play();
        Destroy(gameObject, 1f);
    }
}
