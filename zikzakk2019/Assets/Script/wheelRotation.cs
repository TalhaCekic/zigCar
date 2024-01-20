using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelRotation : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(100* Time.deltaTime, 0, 100* Time.deltaTime);
    }
    
    public void activeFalse()
    {
        Destroy(this.gameObject);
    }
}
