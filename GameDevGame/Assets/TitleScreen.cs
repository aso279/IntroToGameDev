using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {
	public GameObject Instructions;
	public GameObject title;
	public GameObject start;
	public bool pressed;

	
	// Use this for initialization
	void Start () {
	}
	IEnumerator Intro() {
		pressed = false;
		yield return new WaitForSeconds(.1f);
		pressed = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && pressed == false){
			Instructions.SetActive(true);
			start.SetActive(false);
			title.SetActive(false);
			StartCoroutine(Intro());
		}
		
		if (Input.GetButtonDown("Jump") && pressed == true){
			Application.LoadLevel("Game");
		}
		
	}
}
