using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    public float speed;
    private int flag = 0;
    private float LPX = 0;
    private float LPZ = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(flag)
        {
            case 0:              
                LPX -= speed;
                transform.Translate(-speed, 0, 0);
                if (LPX <= -2)
                {
                    flag = 1;
                }
                break;
            case 1:               
                LPZ -= speed;
                transform.Translate(0, 0, -speed);
                if (LPZ <= 1)
                {
                    flag = 2;
                }
                break;
            case 2:                
                LPX += speed;
                transform.Translate(speed, 0, 0);
                if (LPX >= 2)
                {
                    flag = 3;
                }
                break;
            case 3:              
                LPZ += speed;
                transform.Translate(0, 0, speed);
                if (LPZ >= 4.5)
                {
                    flag = 0;
                }
                break;
        }
    }
}
