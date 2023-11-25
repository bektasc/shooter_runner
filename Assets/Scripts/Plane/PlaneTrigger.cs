using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public PlaneManager planeManager;
    public RangeWall rangeWall;
    public SpeedWall speedWall;
    public GameObject spawnLocationObject;
    public static int obstacleLifeIncreaser;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("Player"))
        {
            planeManager.SpawnNextPlane(spawnLocationObject.transform.position);
            obstacleLifeIncreaser += 3;
            rangeWall.SpawnRangeWall(spawnLocationObject.transform.position, transform.parent);
            speedWall.SpawnSpeedWall(spawnLocationObject.transform.position, transform.parent);
        }
    }

    private void Awake()
    {
        planeManager.SpawnObstacles(spawnLocationObject.transform.position, transform.parent);
    }
}
