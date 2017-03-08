using UnityEngine;
using System.Collections;

public class Chasing : MonoBehaviour {
	public Transform target;
	public float speed = 2f;
	private float minDistance = 1f;
	private float range;

	void Start()
	{
	 target = GameObject.Find("Player").transform;

	}


	void Update ()
		{
		range = Vector2.Distance(transform.position, target.position);
		
		if (range > minDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
	}
}