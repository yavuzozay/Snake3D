using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    private GameObject Bounds;
    private float minX, maxX, minZ, maxZ;

    private void Awake()
    {
        Bounds = GameObject.Find("Bounds");
        minX = Bounds.transform.GetChild(0).transform.position.x;
        maxX = Bounds.transform.GetChild(1).transform.position.x;
        minZ = Bounds.transform.GetChild(2).transform.position.z;
        maxZ = Bounds.transform.GetChild(3).transform.position.z;

    }

    private void Update()
    {
        if (transform.position.x > maxX)
        {
            transform.position =new Vector3(minX,transform.position.y,transform.position.z);
        }
        else if (transform.position.x < minX)
        {
            transform.position = new Vector3(maxZ, transform.position.y, transform.position.z);

        }
        else if (transform.position.z > maxZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, minZ);

        }
        else if (transform.position.z < minZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);


        }
    }
}
