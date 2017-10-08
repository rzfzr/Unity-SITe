using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimpleMovement : MonoBehaviour {



	float speedX = 0;
	float speedY = 0;

	float cycle;
	// Use this for initialization
	void Start() {

		cycle = Random.Range(1f,4f);
		InvokeRepeating("ChangeDirection",5f,cycle);

	}

	// Update is called once per frame
	void Update() {
		transform.position += new Vector3(speedX * Time.deltaTime,0,speedY * Time.deltaTime);

	}


	void ChangeDirection() {

		cycle = Random.Range(1f,4f);
		speedX = Random.Range(-5f,5f);
		speedY = Random.Range(-5f,5f);

	}
}
