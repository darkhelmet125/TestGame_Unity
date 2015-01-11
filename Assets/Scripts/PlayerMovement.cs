using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed;
	private Vector3 input;
	public GameObject startPosition;

	// Use this for initialization
	void Start () {
		transform.position = startPosition.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);

		if(rigidbody.velocity.magnitude < maxSpeed)
			rigidbody.AddForce(input*moveSpeed);
	}

}
