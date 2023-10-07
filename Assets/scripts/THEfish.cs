using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEfish : MonoBehaviour
{
    private bool badweirdtimervariable = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("rah", 1.0f);
        Destroy(gameObject, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (badweirdtimervariable)
        {
            transform.localScale = Vector3.Scale(transform.localScale, new Vector3(1.05f, 1.05f, 1.05f));
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
    void rah()
    {
        badweirdtimervariable = true;
    }
}
