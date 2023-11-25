using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public GameObject _bulletDestroyer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("BulletDestroyer"))
        {
            Destroy(gameObject);
        }
    }
}
