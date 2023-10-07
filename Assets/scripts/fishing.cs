using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing : MonoBehaviour
{
    public AudioSource fail;
    public AudioSource success;
    public int fishofchoice;
    public float difficulty = 0.0f;
    public player player;
    public fishshooter fishshooter;
    public otherFishThing otherfish;
    private int move = -1;
    public bool isfishing = false;
    public GameObject youfishing;
    public Vector3 youresize = new Vector3(1, 1.2f,1);

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(0, 0, -40)); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & !otherfish.canCatch & isfishing)
        {
            otherfish.catchFish(false);
        }
        else if (Input.GetKeyDown(KeyCode.Space) & otherfish.canCatch & isfishing)
        {
            otherfish.catchFish(true);
        }
        if (player.rb.velocity == Vector2.zero && Input.GetKeyDown(KeyCode.Space) && !isfishing)
        {
            gofish();
        }
        if (player.rb.velocity!= Vector2.zero && isfishing)
        {
            otherfish.catchFish(false);
        }
        if (otherfish.transform.localPosition.y >= 3.0f) 
        {
        move = -1;
        }
        if (otherfish.transform.localPosition.y <= -3.0f)
        {
        move = 1;
        }

        if (isfishing)
        {
            otherfish.transform.Translate(Vector2.up * Time.deltaTime * difficulty * move);
        }

    }

    void gofish()
    {
        //I should do wieghted randomization so like the better fishies are rarer but i dont know how to do that and i dont really want to figure it out
        fishofchoice = Random.Range(0, (fishshooter.fishInventory.Length + 1));
        difficulty = 1 + fishofchoice * .75f;
       //WHY IS THERE NO TIMER COMPONENT THIS IS SO ANNOYING RAHHHHHHHHHHHH
       //ALL THE STUPID USELESS BLOAT UNITY ADDS THAT HARDLY ANYONE USES AND THEY DON'T HAVE A SIMPLE CUSTOMIZABLE TIMER COMPONENT 0_0  >:|
       //if there was a timer component i'd make the player wait a few seconds before the fishing skillcheck thing pops up BUT THERE ISNT ONE AUAUUAGHGHG
       //i know its not that hard to just make your own timer BUT i need it to be able to repeat and i need to restart it and give it a new random time 
       //whenever the player starts fishin AND I DONT HAVE TIME FOR THAT AUUGHGGGHHHH GRRRRR
       transform.Translate(new Vector3(0, 0, 40));
       isfishing = true;
    }
    public void moreHooks()
    {
        if (player.hooks > 0)
        {
            youresize.y = (1.01f * player.hooks);
            youfishing.transform.localScale = Vector3.Scale(youfishing.transform.localScale, youresize);
            print("more hooks");
        }
    }
}
