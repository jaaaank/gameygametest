using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class fishshooter : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
    private int fishEquipped = 0;
    /* 
    0 = basic
    1 = duo
    2 = tri
    3 = quad
    4 = deca
    5 = laser
    6 = THE
    7 = sword
    */

    public int[] fishInventory= {10,10,10,10,10,10,10,10};
    public GameObject[] bulletPrefabs;

    // Update is called once per frame
    void Update()
    {
        //YAYYY i had to google how to do this to get it to work
        //I did this in godot once so this code kinda makes sense to me but i dont get why i have to get the camera's position or some of the math stuff
        //anyways when i make enemies chase the player i can do this same thing but replace the mouse position with the player position
        float camDis = cam.transform.position.y - transform.position.y;
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));
        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        //Very weird to me that you're supposed to make all input calls in update() because in GODOT
            //there's an input() function that just runs every time an input is detected

        switch (fishEquipped)
        {
            case 0:
                //single
                shoot(fishEquipped);
            break;

            case 1:
                //duo
                shoot(fishEquipped);
            break; 

            case 2:
                //tri
                shoot(fishEquipped);
            break;

            case 3:
                //quad
                shoot(fishEquipped);
            break;

            case 4:
                //deca
                shoot(fishEquipped);
            break;

            case 5:
                //laser
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Instantiate(bulletPrefabs[5], gameObject.transform);
                }
            break;

            case 6:
                //THE
                shoot(fishEquipped);
            break;
        }
        //this is nasty
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            fishEquipped = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)){
            fishEquipped = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)){
            fishEquipped = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)){
            fishEquipped = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)){
            fishEquipped = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)){
            fishEquipped = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7)){
            fishEquipped = 6;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && fishEquipped!=0){
            fishEquipped -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && fishEquipped!=7){
            fishEquipped += 1;
        }
    }

    public void shoot(int bullet)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && fishInventory[bullet] >0)
        {
            Instantiate(bulletPrefabs[bullet], transform.position, transform.rotation);
            fishInventory[bullet] -= 1;
        }
    }
}