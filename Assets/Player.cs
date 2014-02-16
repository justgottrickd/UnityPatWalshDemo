using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public float gravity;
	public float distToGround;
	public float jumpCount = 1;
	// Use this for initialization
	void Start () {
		distToGround = collider.bounds.extents.y;
	}

	public bool isGrounded(){
		return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);

	}
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(-speed*Time.deltaTime,0,0);
		} else if (Input.GetKey (KeyCode.D))
		{
			transform.Translate(speed*Time.deltaTime,0,0);
		}
		if (Input.GetKeyDown(KeyCode.W) && jumpCount < 2){
			jumpCount++;
			rigidbody.AddForce(0,jumpForce,0, ForceMode.Impulse);

		}

		if(isGrounded ())
			jumpCount =1;
		rigidbody.AddForce (0, -gravity, 0);
	}
}
