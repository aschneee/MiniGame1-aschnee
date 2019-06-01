using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;

    public TextMeshProUGUI timeText;
    public float maxTime = 60f;
    public string deathScene = "EndScene";

	// Use this for initialization
	void Start ()
    {
        time = maxTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeText.text = time.ToString("F");

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time <= 0)
        {
            SceneManager.LoadScene(deathScene);
        }

	}
}
