﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints; // parents
	public bool reSpawn = false;
	private Transform[] spawnPoints;
	private bool lastToggle = false;
	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Respawn")) {
			ReSpawn ();
			Debug.Log ("respawn");
			
		} else {
			
		}
	}
	
	private void ReSpawn() {
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}
}
