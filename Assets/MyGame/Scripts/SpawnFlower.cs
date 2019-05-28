using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower : MonoBehaviour
{
    public Flower flowerPrefab;
    public GameObject flowerParent;

      private void Update()
    {
        //SpawnFl();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnFl();
        }

    }

    private void SpawnFl()
    {    
        Flower flowerClone = (Flower)Instantiate(flowerPrefab, transform.position, transform.rotation);
        float flowerSize = 1f;
        flowerClone.transform.localScale = new Vector3(flowerSize, flowerSize, 0);
        flowerClone.transform.SetParent(flowerParent.transform); //gibt Parent
        flowerClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, +5f), flowerParent.transform.position.y, 0f); //setze lokale Pos
        flowerClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));
    }

  
}

	

