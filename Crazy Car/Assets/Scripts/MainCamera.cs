using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
   
    private Transform Target;
    public float xPos, yPos;
    
    void Start()
    {
        Target = FindObjectOfType<Player>().GetComponent<Transform>();
    }
    void LateUpdate()
    {
        transform.position = new Vector3(Target.transform.position.x + xPos, Target.transform.position.y + yPos, Target.transform.position.z);
    }
}
