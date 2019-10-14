using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficMaker : MonoBehaviour
{
    Transform Player;
    public float DistancePlayer;
    public float BetweenDistance;
    public float Miny, Maxy;
    public Transform[] LocationCreatCar;
    public GameObject [] Car;
    public bool OneWay, TwoWay;
    
    void Start()
    {
        Player = FindObjectOfType<Player>().transform;
        if (OneWay == false && TwoWay == false || OneWay == true && TwoWay == true)
        {
            OneWay = true;
            TwoWay = false;
        }
        if (TwoWay)
        {
            LocationCreatCar[0].Rotate(0, 0, 180);
            LocationCreatCar[1].Rotate(0, 0, 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        DistancePlayer = Mathf.Abs(transform.position.y - Player.transform.position.y);
        if (DistancePlayer < BetweenDistance)
        {
            float NextPos = Random.Range(Miny, Maxy);
            transform.Translate(0,NextPos,0);
            InstantiateCar();
        }
    }

    public void InstantiateCar()
    {
        int RandomPos = Random.Range(0, LocationCreatCar.Length);
        int CarNumber = Random.Range(0, Car.Length);
        Instantiate(Car[CarNumber], LocationCreatCar[RandomPos].position, LocationCreatCar[RandomPos].rotation);
       // if (Car[CarNumber].activeSelf == true)
       //{
       //    InstantiateCar();
      // }
      // else
      // {
        //   Car[CarNumber].transform.position = LocationCreatCar[RandomPos].position;
        //   Car[CarNumber].SetActive(true);
      // }
    }
}
