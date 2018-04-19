using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    //public type[] nameOfArray = new type[insert number here]
    //or
    //type[] nameOfArray = { , , , , ,};

    public GameObject[] shapes;


    private void Start() {
        shapes = GameObject.FindGameObjectsWithTag("Shape");
    }
}
