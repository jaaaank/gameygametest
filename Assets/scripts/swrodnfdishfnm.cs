using System.Collections;
using System.Collections.Generic;
using UnityEngine;




        //this whole thing is just visual
public class swrodnfdishfnm : MonoBehaviour
{
    float speed = 1.0f;
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    void Update()
    {
        speed *= 0.9f;
        transform.Rotate(0, 0, -6000 * Time.deltaTime * speed) ;
    }
}
