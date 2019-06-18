using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsUpdater : MonoBehaviour
{

    public MyScore score;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI flowerAmountText;
    public string flowerText = "flowers: ";
    public GameObject[] flowerScreens;

	// Use this for initialization
	void Start ()
    {
        pointsText.text = score.score.ToString();
        flowerAmountText.text = flowerText + score.flowers.ToString();
        ActivateFlowers();
	}

    public void ActivateFlowers ()
    {
        if (score.flowers >= 5 && score.flowers < 10)
        {
            flowerScreens[0].SetActive(true);
        }
        if (score.flowers >= 10 && score.flowers < 15)
        {
            flowerScreens[1].SetActive(true);
        }
        if (score.flowers >= 15)
        {
            flowerScreens[2].SetActive(true);
        }
    }
}
