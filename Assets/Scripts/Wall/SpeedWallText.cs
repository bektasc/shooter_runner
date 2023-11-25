using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedWallText : MonoBehaviour
{
    public TextMeshProUGUI _speedWallText;

    public float speedIncreaser;
    public int speedMultiplier;
    private void Awake()
    {
        speedMultiplier = Random.Range(2, 9);
        _speedWallText.text = "Speed\n+" + speedMultiplier;
        //Debug.Log("Speed Multiplier = " + speedMultiplier);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            speedIncreaser = (speedMultiplier / 100.0f);
            //Debug.Log("Speed Increaser = "+ speedIncreaser);
            PlayerShoot._attackSpeed -= speedIncreaser;
            //Debug.Log("Attack Speed = " + PlayerShoot._attackSpeed);
            Destroy(this.gameObject);
        }
    }
}
