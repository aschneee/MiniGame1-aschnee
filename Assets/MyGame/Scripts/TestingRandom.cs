using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestingRandom : MonoBehaviour {

    public float rndVal;
    public float rndVal2;
    public int minValX = -6;
    public int maxValX = 6;

    private System.Random rndSystem = new System.Random();
    // Use this for initialization
    void Start () {
        rndVal = rndSystem.Next(0, 10);
        rndVal2 = UnityEngine.Random.Range(4, 100);
        Debug.Log("System Random " + rndVal + " Unity Engine " + rndVal2);
       
       
    }
    public void ChangedRandomCube()
    {
        gameObject.transform.position = new Vector3(rndSystem.Next(minValX, maxValX) - 6f, 0f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
