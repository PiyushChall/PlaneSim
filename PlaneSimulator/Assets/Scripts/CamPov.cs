using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPov : MonoBehaviour
{
    public GameObject plane;
    public Transform tpp;       //ThirdPersonPerspective
    private bool tppp = true;
    public Transform fpp;       //FirstPersonPerspective
    private bool fppp;
    public Transform bvp;       //BattleViewPerspective
    private bool bvpp;
    public GameObject camra;
    public Transform cam;
    public Transform player;
    public float povspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tppp)
        {
            cam.transform.position = tpp.transform.position;
            cam.transform.rotation = tpp.transform.rotation;
        }
        else if (bvpp)
        {
            cam.transform.position = bvp.transform.position;
            cam.transform.rotation = bvp.transform.rotation;
        }
        else if (fppp)
        {
            cam.transform.position = fpp.transform.position;
            cam.transform.rotation = fpp.transform.rotation;
        }
        
        changepov();
    }
    private void changepov()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            
            tppp = true;
            bvpp = false;
            fppp = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            
            bvpp = true;
            tppp = false;
            fppp = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            fppp = true;
            tppp = false;
            bvpp = false;
        }
    }
   
}
