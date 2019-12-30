using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
    [SerializeField]
    private GameObject _enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down at 4 meters per second
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        //if bottom of screen
        if(transform.position.y < -5)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
          
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit " + other.transform.name);

        if (other.tag == "Player")
        {        
            Player player = other.transform.GetComponent<Player>();

            //null checking
            if (player != null)
            {
                player.Damage();
                Debug.Log("damaged");
            }
          
           
            Destroy(this.gameObject);


        }
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
   

      
        
        
    }

