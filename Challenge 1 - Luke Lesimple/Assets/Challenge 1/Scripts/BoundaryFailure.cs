/*
 * Luke Lesimple
 * Challenge 1 Airplane
 * Checks position for going out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoundaryFailure : MonoBehaviour
{
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
