using System.Collections;
using System.Collections.Generic;
using UnityEngine; //name space libarys die eingebunden werden
using UnityEngine.UI;
using TMPro;

//Klassendeklaration
public class ChangeText : MonoBehaviour {

    // deklariert Variable und Zuweisung
    public Text myText;
    public TextMeshProUGUI myTMPText;

    private int countPresses = 0;
    private System.Random rnd = new System.Random();

	// Use this for initialization
	void Start () {
        myText.text = "Halllooooo";
        myTMPText.text = "Nochmal Halllooooo";
        myText.fontSize = 30;
	}
	
    // Methoden deklaration
    public void addPress()
    {
        countPresses++;
        // dasselbe wie countPresses = countPresses + 1;
        //countPresses += 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        Debug.Log(rnd.Next(0, 5));
    }
	// Update is called once per frame
	void Update () {
		
	}
}
//intellicense 