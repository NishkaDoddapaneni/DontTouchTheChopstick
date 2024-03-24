using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
     [Header("Destruction Timer")]
    //after this time this object will be desroyed
    public float timeToDestruction;
    // Start is called before the first frame update
    void Start()
    {
        //Execute based on timeToDestruction
        Invoke("DestoryObject", timeToDestruction);
    }

    // This function will destroy this object :(
    void DestoryObject()
    {
        //destory gameobject
        Destroy(gameObject);
    }
}

