using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	//[Range(-20,20)]
	//[SerializeField]
	public float speed;


	void Start() {

	}

	void Update() {


		//GetComponent<Rigidbody>().AddForce(new Vector3(speed * Input.GetAxis("Horizontal"),0,speed * Input.GetAxis("Vertical")));

		transform.position += new Vector3(speed * Time.deltaTime * Input.GetAxis("Horizontal"),0,speed * Time.deltaTime * Input.GetAxis("Vertical"));



		//print(Input.GetAxis("Horizontal"));


		print(transform.position.x);

	}


}
