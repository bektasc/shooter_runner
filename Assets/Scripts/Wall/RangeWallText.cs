using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RangeWallText : MonoBehaviour
{
    public TextMeshProUGUI _rangeWallText;

    public int rangeIncreaser;
    private void Awake()
    {
        rangeIncreaser = Random.Range(2, 5);
        _rangeWallText.text = "Range\n+" + rangeIncreaser;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            //Debug.Log(PlayerShoot._bulletRange);
            PlayerShoot._bulletRange += rangeIncreaser;
            Destroy(this.gameObject);
        }
    }
}
