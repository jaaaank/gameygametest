using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishing : MonoBehaviour
{
    public int fishofchoice;
    private int difficulty = 1;
    public player player;
    public fishshooter fishshooter;
    public GameObject otherfish;
    private int move = -1;
    private bool isfishing = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(0, 0, -40)); 
    }

    // Update is called once per frame
    void Update()
    {

        if (player.rb.velocity == Vector2.zero && Input.GetKeyDown(KeyCode.Space) && !isfishing)
        {
            gofish();
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
        fishofchoice = Random.Range(0, (fishshooter.fishInventory.Length + 1));
        //WHY IS THERE NO TIMER COMPONENT THIS IS SO ANNOYING RAHHHHHHHHHHHH
        //ALL THE STUPID USELESS BLOAT UNITY ADDS THAT HARDLY ANYONE USES AND THEY DON'T HAVE A SIMPLE CUSTOMIZABLE TIMER COMPONENT 0_0  >:|
        //if there was a timer component i'd make the player wait a few seconds before the fishing skillcheck thing pops up BUT THERE ISNT ONE AUAUUAGHGHG
        //i know its not that hard to just make your own timer BUT i need it to be able to repeat and i need to restart it and give it a new random time 
                //whenever the player starts fishin AND I DONT HAVE TIME FOR THAT AUUGHGGGHHHH GRRRRR
        isfishing = true;
        transform.Translate(new Vector3(0, 0, 40));
    }
}
