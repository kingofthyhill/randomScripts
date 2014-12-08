using UnityEngine;
using System.Collections;

public class tankMovement : MonoBehaviour {

	public float speedFactor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)){
			rigidbody.velocity += Vector3.right * speedFactor * Mathf.Abs (rigidbody.velocity.x);
			if (Mathf.Abs (rigidbody.velocity.x) <= 1) {
				rigidbody.velocity += Vector3.right * 1;
			}
		} if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody.velocity += Vector3.left * speedFactor * Mathf.Abs (rigidbody.velocity.x);
			if (Mathf.Abs (rigidbody.velocity.x) <= 1) {
				rigidbody.velocity += Vector3.left * 1;
			}
		} if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody.velocity += Vector3.forward * speedFactor * Mathf.Abs (rigidbody.velocity.z);
			if (Mathf.Abs (rigidbody.velocity.z) <= 1) {
				rigidbody.velocity += Vector3.forward * 1;
			}
		} if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody.velocity += Vector3.back * speedFactor * Mathf.Abs (rigidbody.velocity.z);
			if (Mathf.Abs (rigidbody.velocity.z) <= 1) {
				rigidbody.velocity += Vector3.back * 1;
			}
		}
	}
}
