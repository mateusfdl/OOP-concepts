using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Reference of this instance
        FirstClass reference = this;

        Debug.Log(reference.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
