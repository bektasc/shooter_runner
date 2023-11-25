using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public TextMeshProUGUI _text;
    //public GameOver gameOver;

    public float _obstacleLife;
    public static int boxDestroyed;

    private void Awake()
    {
        _obstacleLife = Random.Range(1 + PlaneTrigger.obstacleLifeIncreaser, 4 + PlaneTrigger.obstacleLifeIncreaser);
        _text.text = _obstacleLife.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent(out BulletMovement _))
        {
            _obstacleLife--;
            Destroy(other.gameObject);
            _text.text = _obstacleLife.ToString();
        }
        
        if (_obstacleLife == 0 && other.gameObject.TryGetComponent(out BulletMovement spawn))
        {
            Destroy(this.gameObject);
            boxDestroyed += 1;
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
