using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverText;

    public static int gamefinished;
    
    // Update is called once per frame
    private void Update()
    {
        transform.position = objectToFollow.transform.position - (Vector3.forward * 10) + (Vector3.up * 5);
        if (gamefinished == 1)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Game Over \n Box Destroyed : " + Obstacle._boxDestroyed;
            Time.timeScale = 0;
        }
    }
}
