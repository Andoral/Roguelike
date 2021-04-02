using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
	public float mousespeed = 20f;
    [SerializeField]
    public GameObject player;
    public Camera cam;
 
    void Start()
    {

    }

    void Update()
    {
    	float Move = Input.GetAxis ("Mouse ScrollWheel");
    	if((cam.fieldOfView < 35 && Move > 0) || (cam.fieldOfView > 90 && Move < 0))
    	{

    	}
    	else
    	{
    		cam.fieldOfView -= Input.GetAxis ("Mouse ScrollWheel")* mousespeed;

    	}
    	
    	transform.position = new Vector3(player.transform.position.x,player.transform.position.y, -10f); 
    }
}
