using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartEnemy : MonoBehaviour {
	float speed = 1f;


	float cycle;
	GameObject player;
	void Start() {
		player = GameObject.Find("Player");
		speed = speed * Time.deltaTime;
	}


	RaycastHit hit;
	void Update() {


		Ray ray = new Ray(transform.position,(player.transform.position - transform.position));
		RaycastHit hit;

		if (Physics.Raycast(ray,out hit)) {

			if (hit.transform == player.transform) {

				if (Vector3.Distance(player.transform.position,transform.position) > 10) {
					Debug.DrawLine(ray.origin,hit.point,Color.yellow);

					print("Too far");
				} else {

					Debug.DrawLine(ray.origin,hit.point,Color.green);

					print("I can see you");
				}

			} else {

				Debug.DrawLine(ray.origin,hit.point,Color.red);

				print("I cannot see you");
			}
		}

		if (Vector3.Distance(player.transform.position,transform.position) < 10 && Physics.Raycast(ray,out hit) && hit.transform == player.transform) {
			print("in radar");

			if (player.transform.localScale.x >= transform.localScale.x) {
				//print("corre");
				transform.position = Vector3.MoveTowards(transform.position,player.transform.position,-speed);

			} else {
				transform.position = Vector3.MoveTowards(transform.position,player.transform.position,speed);
				//print("pega");
			}
		}

		//transform.position += new Vector3(speedX * Time.deltaTime,0,speedY * Time.deltaTime);

	}

}
