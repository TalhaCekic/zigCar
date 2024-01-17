using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public GameObject BallLocation;
    Vector3 fark;
    
    void Start()
    {
        BallLocation = GameObject.FindWithTag("Player");
        fark = transform.position - BallLocation.transform.position;
    }

    
    void Update()
    {
        //BallLocation = GameObject.FindWithTag("Player");
        if(TopMovement.fall == false && BallLocation !=null)
        {
            transform.position = BallLocation.transform.position + fark;
        }
        
    }
}
