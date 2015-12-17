using UnityEngine;
using System.Collections;

public class CamraFollow : MonoBehaviour {

	//platformer game
	//Jefferson CHHIN
	//Last Modifited October 26 2015
	//follows the player in a smoth way, slow to follow if the player is falling
	//Code from Unity Ask
	
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target; //the taget is followed by the user 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (target)
		{
			Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position); //
			Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta; // the came isn't fixed to the player so if the player moves very fast the camra will gradualy keep up
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
		
	}
}
