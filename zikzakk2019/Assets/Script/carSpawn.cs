using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour
{
    public static carSpawn instance;
    public bool isSpawn;

    private void Awake()
    {
        
    }

    void Start()
    {
        instance = this;

    }

    void Update()
    {
        if (isSpawn)
        {
            Instantiate(selectedCar.instance.selecetCar);
            isSpawn = false;
        }
    }
}
