using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Changes the color of the Player Object when standing on a specific tile.
public class IfStatements : MonoBehaviour
{
  void OnTriggerEnter (Collider col)
	{
   	if(col.gameObject.name == "Red")
   		{
     		col.gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
  	  
	else if(col.gameObject.name == "Green")
		{
		col.gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		
	else if(col.gameObject.name == "Blue")
		{
		col.gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}