using UnityEngine;
using System.Collections;


public class PickUpController : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 24 2015
	//Player destorys this sprite on contact 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
			Debug.Log("addscore");
			Destroy(gameObject);

	}
}
