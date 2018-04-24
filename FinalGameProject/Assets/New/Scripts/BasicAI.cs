using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour {

	public NavMeshAgent Agent;
	public Transform player;

    // Use this for initialization
    void Start () {
		Agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		Agent.destination = player.position;
	}
}
