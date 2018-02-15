using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

// From the very little I did understand (mainly because I was fixated on repairing coding script), arrays are the equivalent to the
// ..."genus" section of the  binomial system of nomenclature (A.K.A. Genus Species Family) and the loop is the "species, where each array 
// defines a group of certain areas (I.E. list of scores, player order, etc.) with the loop defining how many array elements are used 
// (I.E. the number in between the brackets used for defining an array), as seen below:	
    public string[4] Players;
    public int[2] Scores;
    public PowerUp[1] PowerUps;
    public Player[7] Players;
    public string[13] Enemies
    public int[50] Stamina;
    public int[150] HP;
    public string[1] Boss;
    public int[42] Level;
    public int[600] Time;
	    
// Each string/int/reference, on their own, gives the basic call back to another variable, allowing the user to create multiple command
// on their own, but after adding the [] symbols, these can be automatically set via Unity's program without having to write every
// single variable while the number specifies the element, thus avoiding unnecessary infinite repeatings that use all of the game's data.

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
