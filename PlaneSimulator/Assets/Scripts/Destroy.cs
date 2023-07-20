using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DeathEffect2;
    public Transform spawnPoint;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Buildings")
        {
            
            //this code just destroys the gameobject on which the script is attached when it collides with another object. 
            Destroy(plane);

            //this code tells the computer to instantiate(spawn) the gameobject stored in the Deatheffect2 variable when it collides with another game object.
            //Here the DeathEffect2 is a variable in which we can store the prefab.
            //transform.position specifies where the prefab will be spawned.
            //Quaternion.identity is used to specify that we dont want any rotation to our spawned prefab.
           // Instantiate(DeathEffect2, transform.position, Quaternion.identity);
        }


    }
}
