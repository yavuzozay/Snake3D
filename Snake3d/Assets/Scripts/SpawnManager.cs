using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoSingleton<SpawnManager>
{
   


    public  void Spawn(GameObject spawnObj)
    {
        float rndX = Random.RandomRange(Bounds.MinX, Bounds.MaxX);
        float rndZ = Random.RandomRange(Bounds.MinZ, Bounds.MaxZ);
        Vector3 spawnPos = new Vector3(rndX, 0, rndZ);
        Instantiate(spawnObj,spawnPos,spawnObj.transform.rotation);
    }

}
