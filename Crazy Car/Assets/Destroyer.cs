using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TrafficCar"))
        {
           // other.gameObject.SetActive(false);
           Destroy(other.gameObject);
        }
    }
}
