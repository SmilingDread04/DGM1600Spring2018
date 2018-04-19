using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Makes the different colors act in very specific ways when colliding with the object.
public class ElseClause : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Red")
        {
            Destroy(col.gameObject);
            //col.gameObject.GetComponent<Renderer>().material.color = Color.blue; (makes tile change color)
        }

        else if (col.gameObject.name == "Green")
        {
            Destroy(col.gameObject);
        }

        else if (col.gameObject.name == "Blue")
        {
            Destroy(col.gameObject);
            //Can't activate w/o Rigidbody2D scriptt (can't be added to player)
            //GetComponent<Rigidbody2D>().gravityScale = 0;
            //GetComponent<BoxCollider2D>().isTrigger = true; //Might be able to remove with no ramifications
            //GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
        }

        //else if(col.gameObject.name == "Invisible"
        //{
        //Application.LoadLevel();	
        //}
    }
}