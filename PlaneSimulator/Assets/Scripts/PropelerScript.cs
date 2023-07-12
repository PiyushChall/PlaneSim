using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelerScript : MonoBehaviour
{
    private float propSpeed = 1f;
    private float accelarateSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, propSpeed, Space.Self);
        speedIncrease();
        speedDecrease();
    }
    private void speedIncrease()
    {
        if (Input.GetKeyDown(KeyCode.Space) && propSpeed != 10)
        {
            propSpeed = propSpeed + accelarateSpeed;
        }
    }
    private void speedDecrease()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && propSpeed != 1)
        {
            propSpeed = propSpeed - accelarateSpeed;
        }
    }
}
