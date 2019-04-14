using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private float life = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Menu");
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        if(other.tag == "enemy")
        {
            life -= 5;
        }
    }

}
