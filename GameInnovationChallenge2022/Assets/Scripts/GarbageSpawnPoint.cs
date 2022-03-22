using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawnPoint : MonoBehaviour
{
    public GameObject garbageEnemy;
    public Transform garbageSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGarbage());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnGarbage()
    {
    Instantiate(garbageEnemy, garbageSpawnPoint);
    yield return new WaitForSeconds(8);
    }


}
