using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(transform.eulerAngles);
        transform.Rotate(0, 90, 0);
        transform.Translate(5, 0, 0);
        
        print(transform.localEulerAngles);
        print(transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
