using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour {


	//public 
	GameObject player;
	void Start() {
		player = GameObject.Find("Player");
		//GetComponent<NavMeshAgent>().destination = player.transform.position;


	}

	// Update is called once per frame
	void Update() {

		if (player.transform.localScale.x >= transform.localScale.x) {
			GetComponent<NavMeshAgent>().destination = transform.position + ((transform.position - player.transform.position));
			//print("corre");
		} else {
			GetComponent<NavMeshAgent>().destination = player.transform.position;
			//print("pega");
		}


	}
}
