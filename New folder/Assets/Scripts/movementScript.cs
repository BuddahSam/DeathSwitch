using UnityEngine;
using System.Collections;

public class movementScript : MonoBehaviour {

	private Vector3 postition;
	public float speed;
	public CharacterController controller;

	public AnimationClip run;
	public AnimationClip idle;
	public AnimationClip meleAttack;


	// Use this for initialization
	void Start () {
		postition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			//Locate where Player Clicked Terrain
			locatePosition();
		}

		//Move the player to position
		moveToPosition();
	}

	void locatePosition()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit, 1000)) 
			{
			postition = new Vector3(hit.point.x, hit.point.y, hit.point.z);
			//Debug.Log(postition);
		}
	}

	void moveToPosition()
	{

		// when player is moving
		if (Vector3.Distance (transform.position, postition) > 1) {
			Quaternion newRotation = Quaternion.LookRotation (postition - transform.position);

			newRotation.x = 0f;
			newRotation.z = 0f;

			transform.rotation = Quaternion.Slerp (transform.rotation, newRotation, Time.deltaTime * 10);
			controller.SimpleMove (transform.forward * speed);

			animation.Play(run.name);
		} 

		//for when player is stationary
		else
		{
			animation.Play(idle.name);
		}
	}
}
