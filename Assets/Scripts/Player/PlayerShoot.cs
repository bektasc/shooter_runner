using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject BulletDestroyerPrefab;

    [SerializeField] public static float _attackSpeed;
    [SerializeField] public static float _bulletRange;

    private float _newAttackSpeed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BulletSpawn());
        _attackSpeed = 1;
    }

    private void Update()
    {
        BulletWallPos();
        _newAttackSpeed = _attackSpeed;
    }
    IEnumerator BulletSpawn()
    {
        while (true)
        {
            Instantiate(_bullet, transform.position + new Vector3(0.05f, 1f, 0.5f), transform.rotation * Quaternion.Euler(90,0,0));
            //Instantiate(_bullet, transform.position + new Vector3(0.03f, 0.97f, .5f), Quaternion.identity);
            yield return new WaitForSeconds(_newAttackSpeed);
        }
    }

    private void BulletWallPos()
    {
        if (_bulletRange < 200)
        {

            BulletDestroyerPrefab.transform.position = transform.position + new Vector3(0, 0, 20 + _bulletRange);
        }
        else
        {
            BulletDestroyerPrefab.transform.position = transform.position + new Vector3(0, 0, 200);
        }
    }
}
