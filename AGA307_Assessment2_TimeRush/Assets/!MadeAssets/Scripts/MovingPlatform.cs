using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Transform> platformStops;
    public int nextStop;
    public float delay;
    public float speed;
    bool isWaiting = false;
    
    
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isWaiting)
            return;

        // distance between points is less than an amount
        if ((platformStops[nextStop].position - transform.position).magnitude < 0.1f )
        //if (transform.position == platformStops[nextStop].position)
        {
            isWaiting = true;
            transform.position = platformStops[nextStop].position;
            Invoke("FindNextStop", delay);
            
        }
        else
        {
            MovePlatform();
        }



        
    }




    void MovePlatform()
    {
        Vector3 moving = platformStops[nextStop].position - transform.position;
        transform.position += (moving / moving.magnitude) * speed * Time.deltaTime;
    }
    void FindNextStop()
    {
        nextStop++;
        nextStop = nextStop % platformStops.Count;
        isWaiting = false;
    }



}
