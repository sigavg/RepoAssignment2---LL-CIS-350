/*
 * Luke Lesimple
 * Prototype 1 Driving Simulator
 * Edits text in trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerEnterTrigger : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trigger Zone"))
        {
            ScoreManager.score++;
        }
    }
}
