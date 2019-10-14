using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCar : MonoBehaviour
{
      float Speed;
    public float MinSpeed, MaxSpeed;
   // public Transform DrawRayPos;
   // public float DistanceRay;
   // private RaycastHit2D Hit;
   // private bool Normal = true;
    void Start()
    {
        Speed = Random.Range(MinSpeed, MaxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Speed * Time.deltaTime, 0);
       // Hit = Physics2D.Raycast(DrawRayPos.position, new Vector2(0, 1), DistanceRay);
        
       // if (Hit != null)
       // {
           // if (Normal)
           // {
             //   Debug.DrawRay(DrawRayPos.position, new Vector2(0, 1 * DistanceRay), Color.cyan);
              //  Hit = Physics2D.Raycast(DrawRayPos.position, new Vector2(0, 1), DistanceRay);

             //   print("Car");

              //  if (Hit.collider.CompareTag("TrafficCar"))
               // {
               //     Speed = Hit.collider.GetComponent<TrafficCar>().Speed;
                 //   Normal = false;
              //  }
           // }
       // }
    }
}

