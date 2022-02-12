using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private static float minX, maxX, minZ, maxZ;

    void Awake()
    {
        minX = transform.GetChild(0).transform.position.x;
        maxX =transform.GetChild(1).transform.position.x;
        minZ = transform.GetChild(2).transform.position.z;
        maxZ = transform.GetChild(3).transform.position.z;
    }

    public static float MinX
    {
        get { return minX; }
    }
    public static float MaxX
    {
        get { return maxX; }
    }
    public static float MinZ
    {
        get { return minZ; }
    }
    public static float MaxZ
    {
        get { return maxZ; }
    }
}
