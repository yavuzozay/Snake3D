using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
   

    private void Update()
    {
        CheckBounds();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SnakeBody"))
        {
            EventManager.Fire_onGameOver();
            Debug.Log("Kuyruða bastýn !");
        }
    }
    
    private void CheckBounds()
    {
        if (transform.position.x > Bounds.MaxX)
        {
            transform.position = new Vector3(Bounds.MinX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < Bounds.MinX)
        {
            transform.position = new Vector3(Bounds.MaxX, transform.position.y, transform.position.z);

        }
        else if (transform.position.z > Bounds.MaxZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Bounds.MinZ);

        }
        else if (transform.position.z < Bounds.MinZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Bounds.MaxZ);


        }
    }
}
