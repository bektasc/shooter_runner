using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedWall : MonoBehaviour
{
    public GameObject speedWallPrefab;

    private int numberOfWall;

    public void SpawnSpeedWall(Vector3 planeSpawnPosition, Transform parent)
    {
        numberOfWall = Random.Range(0, 2);
        if (numberOfWall == 1)
        {
            GameObject RangeWall = Instantiate(speedWallPrefab,
                        planeSpawnPosition +
                        Vector3.back * Random.Range(0, 50) +
                        new Vector3(Random.Range(-1, 2) * Random.Range(0, 12), 3, 0),
                        Quaternion.identity);
        }
    }
}
