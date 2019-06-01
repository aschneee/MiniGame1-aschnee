using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 5.0f;
    private int lives = 3;
    private int liveObjectIndex = 0;
    private int flowers = 0;

    public string deathScene = "EndScene";
    public GameObject[] hearts;
    public MyScore score;

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, -5.3f, 5.3f);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "bee(Clone)")
        {
            DecreaseLive(1);
        }
        else if (col.gameObject.name == "flower(Clone)")
        {
            CollectFlower();
        }
    }

    private void DecreaseLive(int amount)
    {
        lives -= amount;

        hearts[liveObjectIndex].SetActive(false);
        liveObjectIndex++;

        if (lives <= 0)
        {
            SceneManager.LoadScene(deathScene);
        }
    }

    private void CollectFlower ()
    {
        flowers++;
        score.flowers++;
    }
}
