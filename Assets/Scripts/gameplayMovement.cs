using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplayMovement : MonoBehaviour
{
    //responsavel por mover a nave pelo espaco, junto a camera e as particulas
    //seguir uma sequencia de caminhos, atraves de gameObjects. 
    //waypoints serao os lugares em que os gameplay movement ira 
    public GameObject[] waypoints;
    int index = 0;
    Vector3 startingPosition;
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[index].transform.position) < 10)
        {
            index++;
        }
        if(index + 1 > waypoints.Length && Vector3.Distance(transform.position, waypoints[index].transform.position) < 10)
        {
            index = 0;
            transform.position = startingPosition;
        }
        Quaternion lookat = Quaternion.LookRotation(waypoints[index].transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookat, Time.deltaTime );
        transform.position = Vector3.MoveTowards(transform.position,
                                                 waypoints[index].transform.position,
                                                Time.deltaTime * 10f);
    }
}
