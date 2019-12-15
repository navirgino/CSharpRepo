using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _speed = 10.5f;

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        CalcMovement(); 
    }
    void CalcMovement()
    {
       
     if (Input.GetKeyDown(KeyCode.Space))
        {
     
        }
    }
}
