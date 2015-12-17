using UnityEngine;
using System.Collections;

public class PlatformFallController : MonoBehaviour {
	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 26 2015
	//Controlls what cause the Platform to fall
	//Code from Unity Learn

	public float fallDelay = 1f;
	
	
	private Rigidbody2D rb2d;
	
	void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Invoke ("Fall", fallDelay);
		}
	}
	
	void Fall()
	{
		rb2d.isKinematic = false;
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Endgame")) 
		{
			Destroy (gameObject);//the ground will destory itsself also when it hits the deathtigger
		}
	}
}
