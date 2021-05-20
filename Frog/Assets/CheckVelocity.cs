using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = GetComponent<Rigidbody>().velocity.x;
        float y = GetComponent<Rigidbody>().velocity.y;
        float z = GetComponent<Rigidbody>().velocity.z;
        Debug.Log(x + " " + y + " " + z);
    }
}
