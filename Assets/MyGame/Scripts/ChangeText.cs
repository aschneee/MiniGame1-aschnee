using System.Collections;
using System.Collections.Generic;
using UnityEngine; //name space libarys die eingebunden werden
using UnityEngine.UI;
using TMPro;

//Klassendeklaration
public class ChangeText : MonoBehaviour
{

    // deklariert Variable und Zuweisung
    public Text myText;
    public TextMeshProUGUI myTMPText;
    public TestingRandom myScript;

    private int countPresses = 0;
    //new ist schlüsselwort was sagt mach ein neues objekt
    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);


	// Use this for initialization
	void Start () {
        myText.text = "Halllooooo";
        myTMPText.text = "Nochmal Halllooooo";
        myText.fontSize = 30;
        Debug.Log("this bish randomizes: " + UnityEngine.Random.Range(0, 1));
    }
	
    // Methoden deklaration
    public void addPress()
    {
        countPresses++;
        // dasselbe wie countPresses = countPresses + 1;
        //countPresses += 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        Debug.Log("this bish randomizes: " + rnd.Next(0, 5));
        Debug.Log("this bish randomizes seed: " + seedRnd.Next(0, 5));
        myScript.ChangedRandomCube();

    }
	// Update is called once per frame
	void Update () {
		
	}
}
//intellicense 