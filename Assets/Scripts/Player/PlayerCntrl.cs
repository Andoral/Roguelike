using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed = 5f;
    [SerializeField]
    private bool Rightkey = true;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Animator anim;

    void Start()
    {
    	anim = GetComponent<Animator>();
    	rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        if(Mathf.Abs(movex) > Mathf.Abs(movey))
        {
            anim.SetFloat("Speed", Mathf.Abs(movex));
        }
        else
        {
            anim.SetFloat("Speed", Mathf.Abs(movey));
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(movex * maxSpeed, movey * maxSpeed);
        if(movex > 0 && !Rightkey)
            Flip();
        else if (movex < 0 && Rightkey)
            Flip();
    }

    private void Flip()
    {
    	Rightkey = !Rightkey;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
