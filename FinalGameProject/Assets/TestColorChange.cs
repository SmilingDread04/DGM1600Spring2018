using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColorChange : MonoBehaviour {
  
  public Material[] material;
  Renderer rend;

  void Start()
  {
	  rend = GetComponent<Renderer>();
	  rend.enabled = true;
	  rend.sharedMaterial = material [0];
  }

  void OnCollisionEnter (Collision col)
	{
   	if(col.gameObject.tag == "Red")
   		{
     		rend.sharedMaterial = material[1];
		}
  	  
	else if(col.gameObject.tag == "Green")
		{
			rend.sharedMaterial = material[2];
		}
		
	else if(col.gameObject.tag == "Blue")
		{
			rend.sharedMaterial = material[3];
		}
	}
}