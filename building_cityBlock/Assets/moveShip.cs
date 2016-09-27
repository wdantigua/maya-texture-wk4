using UnityEngine;
using System.Collections;
public class moveShip : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	public float autoSpeed = 30f;

	void Update ()
	{

		if (Input.GetKey (KeyCode.UpArrow))
		{
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);

		}

		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			GetComponent <AudioSource> ().Play();
		}
		else 
		{

			transform.position -= transform.forward * Time.deltaTime * autoSpeed;
		}

		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.DownArrow))
			transform.position += transform.forward * Time.deltaTime * (autoSpeed - 15);

		if(Input.GetKey(KeyCode.A))
			transform.Rotate(transform.forward, turnSpeed * Time.deltaTime);

	}
}
