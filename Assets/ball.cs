using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
	// creates two public variables; 1 vector3, 1 floating points
	public float bonusLength = 0f;
	public float raycastLength;
	public Vector3 bounceSpeed;
	public bool change = true;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
//Runs raycastLengthDeterminiation with bonusLength as the parameter.
		raycastLengthDeterminiation (bonusLength);
//Makes the ball bounce if isTouching is true.
		if (isTouching() == true){
//Runs the function bounce with bounceSpeed as the parameter
			bounce (bounceSpeed);
		}
	}
	//Makes the rigidbody.velocity equal to the vector3 parameter bounceVelocity.
	void bounce (Vector3 bounceVelocity) {
		rigidbody.velocity = bounceVelocity;
	}
	//Makes raycast length equal to half of the largest of the X,Y, and Z plus extraLength
	void raycastLengthDeterminiation (float extralength) {
		if (transform.localScale.x >= transform.localScale.y && transform.localScale.x >= transform.localScale.z) {
				raycastLength = transform.localScale.x/2 + extralength;
			} else if (transform.localScale.y >= transform.localScale.x && transform.localScale.y >= transform.localScale.z) {
				raycastLength = transform.localScale.y/2 + extralength;
			} else if (transform.localScale.z >= transform.localScale.x && transform.localScale.z >= transform.localScale.y) {
				raycastLength = transform.localScale.z/2 + extralength;
			}
		}
	//Returns true if there is an object raycastLength distance below the center of our initial object.
	bool isTouching () {
			return Physics.Raycast (transform.position, Vector3.down, raycastLength);
		}
}