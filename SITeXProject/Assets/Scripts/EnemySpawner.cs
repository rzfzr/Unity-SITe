using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	void Start() {
		InvokeRepeating("Spawn",6f,2f);
	}

	void Spawn() {
		Instantiate(enemyPrefab,transform);
	}


}
