using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject enemy;
	void Start() {
		InvokeRepeating("Spawn1",2f,1f);
	}

	void Spawn1() {

		GameObject temp = Instantiate(enemy,transform);
		float rand = Random.Range(0.1f,5);

		temp.GetComponent<Renderer>().material.color = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
		temp.transform.localScale = new Vector3(rand,rand,rand);

	}
}
