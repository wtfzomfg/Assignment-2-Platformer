using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColliderController : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 26 2015
	//Collider for objects and audio Sources

	public Text healthLabel;//This displays the white text on Health (100 - 0)
	public Text scoreLabel; //displays the current score of the play
	public Text gameOverLabel; //display a game over label
	public Text finalScoreLabel; //display the last score gained from the player
	public Text restartLabel; //display "press R to reset"
	public int scoreValue = 0;// the start game score
	public int healthValue = 100; //the start game health


	//private 
	private SpriteRenderer sprite_renderer;
	private AudioSource[] _audioSources;// an array
	private AudioSource _HazardAuioSource, _PickUpAudioSource;
	private bool endgame;

	// Use this for initialization
	void Start () {
		this._SetScore ();

		this._audioSources = this.GetComponents<AudioSource> ();
		this._HazardAuioSource = this._audioSources [0];// ouch sound
		this._PickUpAudioSource = this._audioSources [1];// pick sound




		this.endgame = false;//So the game doens't start with the endgame display
		this.gameOverLabel.enabled = false;//the game will not start displaying the score till the game is over
		this.finalScoreLabel.enabled = false; // for final score
		this.restartLabel.enabled = false; //for press R to restart
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.R) && endgame) //only when the player hits the death tigger they may resest it
		{
			Application.LoadLevel(Application.loadedLevel); //reloads the level 
			
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Coin")) 
		{
			this.scoreValue += 100;
			this._PickUpAudioSource.Play();//play my voice of yay 
		}
			
		if (other.gameObject.CompareTag("Endgame"))
		{
			this._EndGame();
		}
		if (other.gameObject.CompareTag ("Enemy")) 
		{
			this.healthValue -= 20;
			this._HazardAuioSource.Play (); //play ouch

			if(this.healthValue <= 0)
			{
				_EndGame();
				gameObject.GetComponent<Animator>().enabled = false; //destorys the Animator
				gameObject.GetComponent<SpriteRenderer>().enabled = false; //destory spriteRender
				gameObject.GetComponent<CircleCollider2D>().enabled = false;
			}
		}
		this._SetScore ();
	}
	private void _SetScore()
	{
		this.healthLabel.text = "Health :" + this.healthValue; //will display the player health
		this.scoreLabel.text = "Score: " + this.scoreValue;// this will display as Score

	}
	private void _EndGame()
	{
		this.healthLabel.enabled = false;
		this.scoreLabel.enabled = false;
		this.gameOverLabel.enabled = true;
		this.finalScoreLabel.enabled = true;
		this.restartLabel.enabled = true;
		this.finalScoreLabel.text = "Score: " + this.scoreValue;
		this.endgame = true;

		
		
		
	}

}
