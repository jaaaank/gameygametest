using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherFishThing : MonoBehaviour
{
    public fishing mainfishthing;
    private bool isfishing= false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space) && isfishing)
        {
            catchFish(true);
        }
    }
    private void catchFish(bool caught)
    {


        transform.Translate(Vector2.up * 1.2f);
        mainfishthing.transform.Translate(new Vector3(0, 0, -40));
    }
}
