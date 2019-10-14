using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject[] Roads;
    public GameObject FirstRoad;
    public GameObject EndRoad;
    private int RoadNumber = 0;
    void Start()
    {
        FirstRoad = Roads[RoadNumber];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveRoad();
        }
    }

    public void MoveRoad()
    {
        FirstRoad.transform.position = EndRoad.transform.GetChild(0).transform.position;
        EndRoad = FirstRoad;
        RoadNumber += 1;
        if (RoadNumber >= Roads.Length)
        {
            RoadNumber = 0;
        }
        FirstRoad = Roads[RoadNumber];
    }
}
