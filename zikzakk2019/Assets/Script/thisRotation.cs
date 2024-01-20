using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisRotation : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 100* Time.deltaTime);
    }
    
    public void activeFalse()
    {
        //Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }
}
