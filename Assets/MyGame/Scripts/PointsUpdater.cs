using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsUpdater : MonoBehaviour {

    public MyScore score;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI flowerAmountText;
    public string flowerText = "flowers: ";

	// Use this for initialization
	void Start () {
        pointsText.text = score.score.ToString();
        flowerAmountText.text = flowerText + score.flowers.ToString();
	}
}
