using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W)){
			anim.SetTrigger ("Up");
			anim.ResetTrigger ("Idle");

		}
		if (Input.GetKeyUp(KeyCode.W)){
			anim.SetTrigger ("Idle");
			anim.ResetTrigger ("Up");
		}
		if (Input.GetKey(KeyCode.S)){
			anim.SetTrigger ("Down");
			anim.ResetTrigger ("Idle");
			
		}
		if (Input.GetKeyUp(KeyCode.S)){
			anim.SetTrigger ("Idle");
			anim.ResetTrigger ("Down");
		}
		if (Input.GetKey(KeyCode.A)){
			anim.SetTrigger ("Left");
			anim.ResetTrigger ("Idle");
		}
		if (Input.GetKeyUp(KeyCode.A)){
			anim.SetTrigger ("Idle");
			anim.ResetTrigger ("Left");
		}
		if (Input.GetKey(KeyCode.D)){
			anim.SetTrigger ("Right");
			anim.ResetTrigger ("Idle");
		}
		if (Input.GetKeyUp(KeyCode.D)){
			anim.SetTrigger ("Idle");
			anim.ResetTrigger ("Right");
		
		}
	}
}
