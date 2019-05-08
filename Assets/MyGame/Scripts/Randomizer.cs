using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Randomizer : MonoBehaviour {

    private int countPresses = 0;
    //new ist schlüsselwort was sagt mach ein neues objekt
    private System.Random rnd = new System.Random();

    // Use this for initialization
    void Start () {
		
	}

    // Methoden deklaration
    public void addPress()
    {
        countPresses++;
        // dasselbe wie countPresses = countPresses + 1;
        //countPresses += 1;
        Debug.Log("counts: " + countPresses);
        Debug.Log("this bish ranomizes" + rnd.Next(0, 5));
    }
    // Update is called once per frame
    void Update () {
		
	}
}
