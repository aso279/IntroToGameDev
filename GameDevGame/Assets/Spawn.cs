using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject prefab;               
	public float spawnTime;
	public bool waveStarted = false;
	public int enemiesLeft;
	public int waveNumber;
	public Transform[] spawnPoints; 
	public Text wave;
	public Text enemies;
	
	// Use this for initialization
	void Start () {
		enemiesLeft = 20;
		StartCoroutine(Ready());
		waveNumber = 1;

	}
	void Spawn1 ()
	{
		if ( enemiesLeft > 0 ){
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (prefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			spawnTime = Random.Range(1f, 4f);
			enemiesLeft -= 1;
		}
	}
	IEnumerator Ready() {
		yield return new WaitForSeconds(.5f);
		InvokeRepeating ("Spawn1", spawnTime, spawnTime);
	}
	// Update is called once per frame
	void Update () {
		wave.text = "Wave " + waveNumber + "/5";
		enemies.text = "Enemies left: " + enemiesLeft;

		if (enemiesLeft == 0 && waveNumber == 1) {
			waveNumber = 2;
			enemiesLeft = 30;

		}
		if (enemiesLeft == 0 && waveNumber == 2) {
			waveNumber = 3;
			enemiesLeft = 35;
			
		}
		if (enemiesLeft == 0 && waveNumber == 3) {
			waveNumber = 4;
			enemiesLeft = 40;
			
		}
		if (enemiesLeft == 0 && waveNumber == 4) {
			waveNumber = 5;
			enemiesLeft = 50;
			
		}
		if (enemiesLeft == 0 && waveNumber == 5) {
			waveNumber = 0;
		}
	}
}
