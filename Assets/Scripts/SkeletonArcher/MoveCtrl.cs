using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

	private float maxSpeed = 5f;
	private bool Rightkey = true;
	private byte aggro = 0;
	private Rigidbody2D rb;
	private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    	rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
    }

    private void Flip()
    {
    	Rightkey = !Rightkey;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
