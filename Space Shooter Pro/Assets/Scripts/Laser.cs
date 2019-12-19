using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _speed = 8f;
  


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
        //translate laser up
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        //if laser position is greater than 8 on the y
        //destroy the obj
        if(transform.position.y >= 7.0f)
        {
            Destroy(gameObject);
        }
    }
}
