using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour {

	public NavMeshAgent Agent;
	public Transform Player;

    // Use this for initialization
    void Start () {
		Agent = GetComponent<NavMeshAgent>();
		Agent.destination = Player.position;
	}
}
