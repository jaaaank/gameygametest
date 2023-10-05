using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    void Start()
    {
        //replace "Gun" with the name of whatever Game Object that's pointing at the mouse
        transform.parent = GameObject.Find("Gun").transform;
        Destroy(gameObject, 1.5f);
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
