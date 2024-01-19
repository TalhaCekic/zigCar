using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisRotation : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 100* Time.deltaTime);
    }
    
    public void activeFalse()
    {
        this.gameObject.SetActive(false);
    }
}
