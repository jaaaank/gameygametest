using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Animations;

public class player : MonoBehaviour
{
    public GameObject swotrmxfisjfk;
    public float speed;
    public fishshooter fishgun;
    public float score;
    public Rigidbody2D rb;
    public int hooks;
    public Vector2 inputVector;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //i could do my own acceleration thing for this dont know if i will 
        //no i wont
        inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = (inputVector.normalized) * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collided");
        if (fishgun.fishInventory[7] <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(swotrmxfisjfk);
        }
        fishgun.fishInventory[7] -=1;
    }

}
