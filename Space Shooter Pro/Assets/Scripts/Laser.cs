using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _speed = 8f;

    void Update()
    {
        CalcMovement();
        DestroyLaser();
    }
    void CalcMovement()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

    }
    void DestroyLaser()
    {
        //if laser position is greater than 8 on the y
        //destroy the obj
        if (transform.position.y >= 7.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
 
