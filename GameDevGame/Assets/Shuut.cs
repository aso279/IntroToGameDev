using UnityEngine;
using System.Collections;

public class Shuut : MonoBehaviour 

{
	public GameObject bullet;
	public float speed = 5.0f;
	public Quaternion rotation = Quaternion.Euler(new Vector3(0, 30, 0));
	public bool shoot = true;

	
	// Use this for initialization
	void Start () 
	{

	}
	IEnumerator Shoot1() {
		shoot = false;
		yield return new WaitForSeconds(.5f);
		shoot = true;
	}
	
	void Update () 
	{
		if (Input.GetMouseButtonDown(0) && shoot == true) 
		{
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y);
			GameObject projectile = (GameObject)Instantiate(bullet, myPos, Quaternion.identity);
			Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
			Vector2 direction = target - myPos;
			direction.Normalize();
			float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			projectile.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 180);
			projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
			StartCoroutine(Shoot1());
		}
	}
}