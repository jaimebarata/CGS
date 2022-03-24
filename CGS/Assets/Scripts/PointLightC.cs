using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightC : MonoBehaviour
{
    GameObject Luz;
    public float speed;
    private float LightRX = 0;
    Vector3 ScaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    // Start is called before the first frame update
    void Start()
    {
        Luz = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LightRX < 180)
        {
            transform.Rotate(speed, 0, 0);
            LightRX += speed;
            Luz.transform.localScale += ScaleChange;
        }
    }
}
