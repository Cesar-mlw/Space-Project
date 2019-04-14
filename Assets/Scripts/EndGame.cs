using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject plyr;
    private  Vector3 plyrPostiton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        plyrPostiton = plyr.transform.position;
        if(Vector3.Distance(plyrPostiton, gameObject.transform.position) <= 30)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
