using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{   
    public Leg leg;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(leg.name);
        // Jumping reference to reference
        string name = leg.fingers[0].gameObject.name;
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
