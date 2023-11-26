using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RangeWall : MonoBehaviour
{
    public GameObject rangeWallPrefab;

    private int numberOfWall;

    public void SpawnRangeWall(Vector3 planeSpawnPosition, Transform parent)
    {
        numberOfWall = Random.Range(0, 2);
        if (numberOfWall == 1)
        {
            GameObject RangeWall = Instantiate(rangeWallPrefab,
                        planeSpawnPosition +
                        Vector3.back * Random.Range(0, 20) +
                        new Vector3(Random.Range(-1, 2) * Random.Range(0, 12), 3, 0),
                       Quaternion.identity);
        }
    }
}

