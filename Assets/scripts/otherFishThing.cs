using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherFishThing : MonoBehaviour
{
    public fishing mainfishthing;
    public fishshooter fishshooter;
    public player playr;
    public bool canCatch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                    //I DONT NEED ANY OF THIS
        //if (Input.GetKeyDown(KeyCode.Space) & mainfishthing.isfishing & canCatch)
        //{
        //    catchFish(true);
        //}

        //if (Input.GetKeyDown(KeyCode.Space) & mainfishthing.isfishing & !canCatch)
        //{
        //    catchFish(false);
        //}
    }

    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    print("isthisworkin");
    //    if (Input.GetKeyDown(KeyCode.Space) && mainfishthing.isfishing)
    //    {
    //        catchFish(true);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canCatch = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canCatch = false;
    }
    public void catchFish(bool caught)
    {
        if (caught)
        {
            mainfishthing.success.Play();
            if (mainfishthing.fishofchoice == 8)
            {
                playr.hooks++;
                mainfishthing.moreHooks();
            }
            else
            {
                fishshooter.fishInventory[mainfishthing.fishofchoice]++;
            }
        }
        else
        {
            mainfishthing.fail.Play();

        }
        transform.Translate(Vector2.up * Random.Range(-4.0f,4.0f));
        mainfishthing.transform.Translate(new Vector3(0, 0, -40));
        mainfishthing.isfishing = false;
        mainfishthing.difficulty = 0.0f;
        fishshooter.updateInterface();
    }
}