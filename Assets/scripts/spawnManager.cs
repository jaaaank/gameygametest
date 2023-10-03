using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class spawnManager : MonoBehaviour
{
    public GameObject enemy;
    public float breaktime;
    public float numenemies;
    public player playaer;
    public Transform spawnpos;
    // Start is called before the first frame update
    void Start()
    {
        playaer.score = 0;
        Invoke("hellishLoop", breaktime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //this loop is gonna be nasty and i WILL NOT remember how it works so i better get it right first try
    void hellishLoop()
    {

        //had to learn for loops in c# for this, its very different to python and GDscript (the language godot uses)
        for (int i = 0;  i<=numenemies; i++)
        {
            Instantiate(enemy, randomizeSpawn(),enemy.transform.rotation);
        }
        playaer.score *= 1.15f;
        numenemies *= 1.15f;
        breaktime *= .95f;
        Invoke("hellishLoop", breaktime);
    }

    public Vector2 randomizeSpawn()
    {
        int spawnpoint = Random.Range(0, 10);  
        switch (spawnpoint)
        {

            case 0:
                return new Vector2(0, 0);
            case 1:
                return new Vector2(10, 10);
            default:
                return new Vector2(0, 0);
        }
    }

}
