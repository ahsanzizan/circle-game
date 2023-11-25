using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    [Header("Score")]
    public TextMeshProUGUI scoreTxt;
    private float score = 0;

    private void Update()
    {
        if (player == null)
        {
            Time.timeScale = 0;
        }

        score += Time.deltaTime;
        scoreTxt.text = "Score: " + ((int) score).ToString();
    }
}
