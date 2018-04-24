using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public Slider healthbar;//Reference To Slider

    public static int health; //Health Of Player

    // Use this for initialization
    void Start()
    {
        health = 100; //Max Health Of Player, Should Be Same As Max Slider Value       
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health; //Update Slider's Value To Equal Player's Health

        ChangeHealth(); //Used If No Triggers Are Present
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Enemy")) { if (health > 0) health = health - 1; }//Stop Damaging Once Health Reaches 0
        if (other.gameObject.name.Equals("Green")) { if (health < 100) health = health + 100; }//Stops Healing Once Health Reaches 100
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("Enemy")) { if (health > 0) health = health - 1; }//Stop Damaging Once Health Reaches 0
    }
    void ChangeHealth()
    {
        if (Input.GetKeyDown(KeyCode.Z)) { if (health > 0) health = health - 20; }
        if (Input.GetKeyDown(KeyCode.X)) { if (health < 100) health = health + 20; }
    }
}