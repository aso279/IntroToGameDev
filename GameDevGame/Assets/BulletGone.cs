using UnityEngine;
using System.Collections;

public class BulletGone : MonoBehaviour {
	public Collider2D collision;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Enemy"){
			Destroy (gameObject);
		}
			if (collision.gameObject.tag == "Wall"){
				Destroy (gameObject);
			}
		
	}
}
