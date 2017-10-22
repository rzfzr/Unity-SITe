using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	float speedX = 0, speedZ = 0;
	// Use this for initialization
	void Start() {
		InvokeRepeating("ChangeDirection",5f,2f);
	}

	void ChangeDirection() {
		speedX = Random.Range(-10,10);
		speedZ = Random.Range(-10,10);

	}

	void Update() {
		transform.position += new Vector3(speedX * Time.deltaTime,0,speedZ *
			Time.deltaTime);


	}
}
