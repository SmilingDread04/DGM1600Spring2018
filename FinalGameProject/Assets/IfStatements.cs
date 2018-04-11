using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Changes the color of the Player Object when standing on a specific tile.
public class IfStatements : MonoBehaviour 
{
  void OnCollisionEnter (Collision col)
	{
   	if(col.gameObject.name == "Red")
   		{
     		col.gameObject.GetComponent<Renderer>().material.color = Color.Red;
		}
  	  
	else if(col.gameObject.name == "Green")
		{
		col.gameObject.GetComponent<Renderer>().material.color = Color.Green;
		}
		
	else if(col.gameObject.name == "Blue")
		{
		col.gameObject.GetComponent<Renderer>().material.color = Color.Blue;
		}
	}
}
