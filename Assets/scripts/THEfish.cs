using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEfish : MonoBehaviour
{
    public AudioSource sound;
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
            //this kinda sucks because varies by framerate but this is due tomorrow and it's really not that bad so whatever
            transform.localScale = Vector3.Scale(transform.localScale, new Vector3(1.25f, 1.25f, 1.25f));
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
    void rah()
    {
        sound.Play();
        badweirdtimervariable = true;
    }
}
