using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed;
	
	private Rigidbody2D rb;
	public int playerHealth;
	public bool iFrames = false;
	public GameObject GameOver;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		playerHealth = 5;
	}
	IEnumerator Hit1() {
		iFrames = true;
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(.1f);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(.1f);
		iFrames = false;
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		
		rb.AddForce (movement * speed);

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Enemy" && iFrames == false){
			playerHealth = playerHealth - 1;
			StartCoroutine(Hit1());
			Debug.Log (playerHealth);

		}
	}
	void Update() {
		if(playerHealth == 0){
		GameOver.SetActive(true);
		}

	}
}