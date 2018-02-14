using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

// From the very little I did understand (mainly because I was fixated on repairing coding script), arrays are the equivalent to the
// ..."genus" section of the  binomial system of nomenclature (A.K.A. Genus Species Family), where each array defines a group of certain
// areas (I.E. list of scores, player order, etc.) without forcing each part to be manually typed by the coder, as seen below:
	
    public string[] Players;
    public int[] Scores;
    public PowerUp[] PowerUps;
    public Player[] Players;
    public string[] Enemies
    public int[] Stamina
    public int[] HP
    public string[] Boss
    public int[] Level
    public int[] Time
	    
// Each string/int/reference, on their own, gives the basic call back to another variable, allowing the user to create multiple command
// on their own, but after adding the [] symbols, these can be automatically set via Unity's program without having to write every
// single variable, thus reducing stress and time used for the problem and applying to more necessary applications.

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
