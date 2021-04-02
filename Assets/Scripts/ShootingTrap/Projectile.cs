using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	[SerializeField]
    private float speed = 10f;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.transform.tag == "Player")
        {
            Manager.currentHealth -=30;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {

    	if(transform.rotation.y == 0)
    	{
    		transform.position = transform.position + new Vector3(Time.deltaTime * speed, 0 , 0 );       
    	}
    	else 
    	{
    		speed *= -1;
    		transform.position = transform.position + new Vector3(Time.deltaTime * speed, 0 , 0 );
    		speed *= -1;
    	}
    }
}
