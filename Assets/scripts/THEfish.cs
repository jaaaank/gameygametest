using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEfish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Scale(transform.localScale, new Vector3(1.05f, 1.05f, 1.05f));
    }
}