using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject ball;

        void Start ()
    {
        StartCoroutine(startSpawning());
	}
    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 4f));
        Instantiate(this.ball, this.spawnPoints[Random.Range(0, this.spawnPoints.Length)].position, Quaternion.identity);
        StartCoroutine(startSpawning());
    }
}
