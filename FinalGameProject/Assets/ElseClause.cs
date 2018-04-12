using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Makes the different colors act in very specific ways when colliding with the object.
public class ElseClause : MonoBehaviour
{
  void OnTriggerEnter (Collider col)
	{
   	if(col.gameObject.name == "Red")
   		{
     		Destroy(col.gameObject);
		}
  	  
	else if(col.gameObject.name == "Green")
		{
		
		}
		
	else if(col.gameObject.name == "Blue")
		{
		GetComponent<Rigidbody2D> ().gravityScale = 0;
		GetComponent<BoxCollider2D> ().isTrigger = true; //Might be able to remove with no ramifications
		GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, .5f);
		}
		
	//else if(col.gameObject.name == "Invisible"
		//{
		//Application.LoadLevel();	
		//}
	}
}
