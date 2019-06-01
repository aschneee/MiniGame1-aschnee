using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsUpdater : MonoBehaviour {

    public MyScore score;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI flowerAmountText;

	// Use this for initialization
	void Start () {
        pointsText.text = score.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
