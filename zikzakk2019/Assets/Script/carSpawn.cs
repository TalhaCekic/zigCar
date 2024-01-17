using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour
{
    //public bool isSpawn;

    private void Awake()
    {
        Instantiate(selectedCar.instance.selecetCar);
    }

    void Start()
    {
       
    }

    void Update()
    {
        
    }
}
