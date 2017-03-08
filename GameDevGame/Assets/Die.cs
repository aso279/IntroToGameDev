using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {
	public Collider2D collision;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Bullet"){
			Destroy (gameObject);
		}
			
	}
}
