using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public Rigidbody2D rb;
	float moveSpeed;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3(0,0,0);
		
		if (Input.GetKey ("a")){
			direction -= Vector3.right;
		}
		
		if(Input.GetKey("d")){
		direction += Vector3.right;
	}
	
	
	if (Input.GetKey ("w")){
		direction += Vector3.forward;     
	}
	
	
	if(Input.GetKey ("s")){
		direction -= Vector3.forward;
	}
	if (direction == Vector3(0,0,0)){
	    rb.AddForce(direction.normalized*moveSpeed*Time.deltaTime);
		}
	}
}
