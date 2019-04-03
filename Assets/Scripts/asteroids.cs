   using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour
{
    public ParticleSystem explo;
    Vector3 randorot;
    // Start is called before the first frame update
    void Start()
    {
        randorot = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(randorot * Time.deltaTime);
    }

    private void OnParticleCollision(GameObject other)
    {
        explo.Play();
        Destroy(gameObject, 0.25f);
    }
    private void ResetAsteroid()
    {

    }
}
