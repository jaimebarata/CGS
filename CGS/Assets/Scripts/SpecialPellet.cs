using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPellet : MonoBehaviour
{
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PelletActive", 0.5f, 0.5f);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    void PelletActive()
    {   if (flag == false)
        {
            gameObject.SetActive(false);
            flag = true;
        }
        else if(flag == true)
        {
            gameObject.SetActive(true);
            flag= false;
        }
    }
}
