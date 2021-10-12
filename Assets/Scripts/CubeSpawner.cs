using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject myPrefab;
    public float minWait = 1f;
    public float maxWait = 3f;

    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    private IEnumerator SpawnCubes()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));
            Instantiate(myPrefab, new Vector3(Random.Range(-6f, 6f), Random.Range(-3f, 3f), 0f), Quaternion.identity);
        }
    }
}
