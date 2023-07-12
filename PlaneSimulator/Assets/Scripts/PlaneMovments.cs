using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovments : MonoBehaviour
{
    public float FlySpeed = 0f;
    public float accelaration = 5f;
    public float YawAmount = 120f;

    private float Yaw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * FlySpeed * Time.deltaTime;

        float horizon = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");


        Yaw += horizon * YawAmount * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 40, Mathf.Abs(vertic)) * Mathf.Sign(vertic);
        float roll = Mathf.Lerp(0, 30, Mathf.Abs(horizon)) * -Mathf.Sign(horizon);

        transform.localRotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);


        speedIncrease();
        speedDecrease();
    }

    private void speedIncrease()
    {
        if (Input.GetKeyDown(KeyCode.Space) && FlySpeed!=30)
        {
            FlySpeed = FlySpeed+accelaration;
        }
    }
    private void speedDecrease()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && FlySpeed!=5)
        {
            FlySpeed = FlySpeed - accelaration;
        }
    }
}
