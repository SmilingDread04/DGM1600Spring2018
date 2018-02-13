using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

    public string[] Players;
    public int[] Scores;
    public PowerUp[] PowerUps;
	public Player[] Players;

    // Use this for initialization
    void Start () {
        foreach (var player in Players) {
            print(player.PlayerName);
			print(player.Score);
			print(player.MPs);
        }

        foreach (var score in Scores) {
            if (score >= 1000) {
                print (score);
            }
        }



        print (Players[0]);
        print (Players[1]);
        print (Players[2]);
        print (Players[3]);
        print (Players[4]);
    }

    // Update is called once per frame
    void Update () {

    }
}