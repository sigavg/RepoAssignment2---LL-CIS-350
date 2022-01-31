/*
 * Luke Lesimple
 * Challenge 1 Airplane
 * Edits text in trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerTriggerBox : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            ScoreManager.score++;
        }
    }
}
