using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {





	public GameObject go;
	void Start() {

	}

	public float speed = 10;
	void Update() {


		//if (Input.GetKey(KeyCode.Space)) {
		GameObject temp = Instantiate(go);
		temp.GetComponent<Renderer>().material.color = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
		//}



		transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,Input.GetAxis("Vertical") * speed * Time.deltaTime);


	}
}
