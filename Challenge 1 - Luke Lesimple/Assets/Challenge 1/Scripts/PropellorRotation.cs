/*
 * Luke Lesimple
 * Challenge 1 Airplane
 * Rotates Propellor
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back, 20);
    }
}
