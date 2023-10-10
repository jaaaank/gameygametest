using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        Invoke("hellishLoop", breaktime);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //this loop is gonna be nasty and i WILL NOT remember how it works so i better get it right first try
    void hellishLoop()
    {

        //had to learn for loops in c# for this, its very different to python and GDscript (the language godot uses)
        for (int i = 0;  i<=numenemies; i++)
        {
            Instantiate(enemy, randomizeSpawn(),enemy.transform.rotation);
        }
        numenemies *= 1.1f;
        breaktime *= .95f;
        Invoke("hellishLoop", breaktime);
    }

    public Vector2 randomizeSpawn()
    {
        int spawnpoint = Random.Range(0, 10);  
        switch (spawnpoint)
        {

            case 0:
                return new Vector2(45, 50);
            case 1:
                return new Vector2(40, 40);
            case 2:
                return new Vector2(-40, -40);
            case 3:
                return new Vector2(40, -40);
            case 4:
                return new Vector2(-40, 40);
            case 5:
                return new Vector2(-50, 40);
            case 6:
                return new Vector2(50, -40);
            case 7:
                return new Vector2(50, -50);
            case 8:
                return new Vector2(-50, -50);
            case 9:
                return new Vector2(-45, 50);
            default:
                return new Vector2(45, -50);
        }
    }

}
