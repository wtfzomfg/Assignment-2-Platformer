using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 25 2015
	//Destory deathtigger when player dies from falling 
	//not required but for visual effects if player dies from falling

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other) //this c# is when the player falls and hits the deathtigger the player won't see it 
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Destroy (gameObject);//the ground will destory itsself also when it hits the deathtigger
		}
	}
}
