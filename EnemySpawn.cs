using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 26 2015
	//enemy random range of spawning


	public Transform[] EnemySpawns;//not so much of "Enemy" but just a random robots that can add more objects that the player needs to jump around or on
	public GameObject Enemy;
	// Use this for initialization
	void Start () {
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Spawn()
	{
		for (int i = 0; i < EnemySpawns.Length; i++)
		{
			int coinFlip = Random.Range (0, 9);
			if (coinFlip > 6)
				Instantiate(Enemy, EnemySpawns[i].position, Quaternion.identity);
		}
	}

}
