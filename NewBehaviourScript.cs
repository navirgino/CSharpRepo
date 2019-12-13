using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour //means inherets or extends to monobehavior
{
    // Start is called before the first frame update

        //public(inside world can use the variable)
        //or private only user knows variable exists reference
        [SerializeField]
        private float _speed = 5.5f;
    void Start()
    {
       //take the current position - new position (0x, 0y, 0z)
       transform.position = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        //test comment for git
        
        
    }
}
