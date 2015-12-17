﻿using UnityEngine;
using System.Collections;

public class CoinSpawnController : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 25 2015
	//controlls how offten coins spawn
	//Code from Unity Learn
	
	public Transform[] coinSpawns;
	public GameObject coin;
	
	// Use this for initialization
	void Start () {
		
		Spawn();//calls the spawn whenever that players starts the game with random spawn
	}
	
	void Spawn()
	{
		for (int i = 0; i < coinSpawns.Length; i++)
		{
			int coinFlip = Random.Range (0, 2);
			if (coinFlip > 0)
				Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
		}
	}

}
