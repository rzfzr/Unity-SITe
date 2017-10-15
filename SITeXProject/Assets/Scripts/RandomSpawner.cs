using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class RandomSpawner : MonoBehaviour {

	public GameObject enemyPrefab;

	float cycle;
	void Start() {
		cycle = Random.Range(1f,4f);
		InvokeRepeating("Spawn",cycle,cycle);
	}

	void Spawn() {
		cycle = Random.Range(1f,4f);
		//Instantiate(enemyPrefab,transform);
		GameObject tempPrefab = Instantiate(enemyPrefab,transform);

		tempPrefab.GetComponent<Renderer>().material.color = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
	}


}
