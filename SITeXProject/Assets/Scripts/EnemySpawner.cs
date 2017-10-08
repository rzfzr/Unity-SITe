using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	void Start() {
		InvokeRepeating("Spawn",5f,2f);
	}

	void Spawn() {
		Instantiate(enemyPrefab,transform);
	}


}
