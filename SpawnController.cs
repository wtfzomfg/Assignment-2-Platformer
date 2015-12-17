using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 24 2015
	//Spawning for the manager which controlls x amount of platforms.
	//Code from Unity Learn

	public int maxPlatforms = 20;// how many platforms can only be 20
	public GameObject platform;
	public float horizontalMin = 7.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6;
	
	
	private Vector2 originPosition;
	
	
	void Start () {
		
		originPosition = transform.position;
		Spawn ();
		
	}
	
	void Spawn()
	{
		for (int i = 0; i < maxPlatforms; i++)
		{
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}
}
