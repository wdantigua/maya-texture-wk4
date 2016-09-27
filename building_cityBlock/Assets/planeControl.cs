using UnityEngine;
using System.Collections;

public class planeControl : MonoBehaviour {


	public float speed = 10;
	public float turnSpeed = 15;
	public float yawAmount = 25;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//gets a 1 unit line(vector3) representation of a line that goes in one direction relative the other transformsto  relative to the 3d space

		float turnAround = Input.GetAxis ("Horizontal")* turnSpeed;

		float yaw = Input.GetAxis ("Horizontal") * -yawAmount;

		Vector3 rotationAmt = new Vector3 (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + turnAround, yaw);

		transform.rotation = Quaternion.Euler (rotationAmt);


		rb.velocity = transform.forward*speed;


	}
}
