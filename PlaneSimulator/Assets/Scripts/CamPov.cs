using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPov : MonoBehaviour
{
    public Transform tpp;       //ThirdPersonPerspective
    public Transform fpp;       //FirstPersonPerspective
    public Transform bvp;       //BattleViewPerspective
    public GameObject camra;
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam.transform.position = tpp.transform.position;
            cam.transform.rotation = tpp.transform.rotation;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam.transform.position = bvp.transform.position;
            cam.transform.rotation = bvp.transform.rotation;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cam.transform.position = fpp.transform.position;
            cam.transform.rotation = fpp.transform.rotation;
        }
    }
   
}
