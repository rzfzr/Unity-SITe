using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]
	float speed = 10;
	//Rigidbody rb;


	void Start() {
		InitialPosition(); //handle position

		//rb = GetComponent<Rigidbody>();
	}

	void InitialPosition() {
		transform.position = new Vector3(0,0,0);
		print("Centralizado");
	}



	void Update() {
		transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);

		//rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Vertical") * speed * Time.deltaTime));
		//if (Input.GetKey(KeyCode.RightArrow)) {
		//	transform.position += new Vector3(1 * speed * Time.deltaTime,0,0);
		//}
		//if (Input.GetKey(KeyCode.LeftArrow)) {
		//	transform.position += new Vector3(-1 * speed * Time.deltaTime,0,0);
		//}
		//if (Input.GetKey(KeyCode.UpArrow)) {
		//	transform.position += new Vector3(0,0,1 * speed * Time.deltaTime);
		//}
		//if (Input.GetKey(KeyCode.DownArrow)) {
		//	transform.position += new Vector3(0,0,-1 * speed * Time.deltaTime);
		//}

	}
}
