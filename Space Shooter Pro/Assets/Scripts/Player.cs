
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour //means inherets or extends to monobehavior
{
    // Start is called before the first frame update

    //public(inside world can use the variable)
    //or private only user knows variable exists reference
    [SerializeField]
    private float _speed = 5.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    [SerializeField]
    private float _fireRate = 0.2f;
    private float _canFire = -1f;
    [SerializeField]
    private int _lives = 3;

    void Start()
    {
        //take the current position - new position (0x, 0y, 0z)
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)
        {
            FireLaser();
        }
        
    }
 

        void CalculateMovement()
        {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        //clamps trans.pos.y between -3.8 and zero, making the above conditional optional
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);

        //setting boundaries to wrap on the x axis!
        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }

        

    }
    void FireLaser()
    {

            _canFire = Time.time + _fireRate;
            //new vector3 for offset
            Vector3 offset = new Vector3(0, 1.0f, 0);
            //quaternion.identity = default rotation
            Instantiate(_laserPrefab, transform.position + offset, Quaternion.identity);
      
    }

    public void Damage()
    {
        _lives--;

        if(_lives < 1)
        {
            Destroy(this.gameObject);
        }
    }
}