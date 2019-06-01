using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleFlower : MonoBehaviour
{
    //private int score = 0;
    // dadurch kann ich auf die Komponente zugreifen in Unity dann noch zuweisen
    public TextMeshProUGUI pointsScore;
    public MyScore score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent " + collision.gameObject.name);

        if (collision.gameObject.name == "bug")
        {
            score.score += 5;
            Debug.Log("score " + score);
            //pointsScore.text = score.score.ToString();

        }
    }
	
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");
    }
    private void Update()
    {
        pointsScore.text = score.score.ToString();
    }
}
