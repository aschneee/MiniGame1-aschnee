using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBee : MonoBehaviour
{
    public Bee beePrefab;
    public GameObject beeParent;

      private void Update()
    {
        //SpawnFl();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(8);
            SpawnBe();
        }

    }

    private void SpawnBe()
    {    
        Bee beeClone = (Bee)Instantiate(beePrefab, transform.position, transform.rotation);
        float beeSize = 1f;
        beeClone.transform.localScale = new Vector3(beeSize, beeSize, 0);
        beeClone.transform.SetParent(beeParent.transform); //gibt Parent
        beeClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, +5f), beeParent.transform.position.y, 0f); //setze lokale Pos
        beeClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, UnityEngine.Random.Range(-10, -1));
    }

  
}

	

