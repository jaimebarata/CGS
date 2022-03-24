using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    Light Luz;
    private bool flag = false;
    private float LightRX = 0;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == false)
        {
            if (LightRX >= 90)
            {
                flag = true;
            }
            LightRX += speed;
            transform.Rotate(speed, 0, 0);
        }
        else
        {
            LightRX -= speed;
            transform.Rotate(-speed, 0, 0);
            if (LightRX <= 0)
            {
                flag = false;
            }
        }
        if (LightRX <= 0.1)
        {
            Luz.color = Color.yellow;
        }
        else if (LightRX >= 60)
        {
            Luz.color = Color.white;
        }
        else if (LightRX <= 60 && flag == true)
        {
            Luz.color = Color.red;
        }
    }
}
