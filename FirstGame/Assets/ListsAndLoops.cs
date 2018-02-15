using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListsAndLoops : MonoBehaviour 
{

	public TheIncredibles TheIncredibles;
	public Text AddMember;

	public string[] PlayerNames;
	public List<string> PlayerNameList;

	private void OnMouseDown() 
	{
		TheIncredibles.FamilyList.Add(AddMember.text);	
	}
}
