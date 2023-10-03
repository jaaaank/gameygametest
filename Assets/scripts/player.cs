using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Animations;

public class player : MonoBehaviour
{
    public float speed;
    public bool fishing;
    public fishshooter fishgun;
    public float score;
    public Rigidbody2D rb;
    public int hooks;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //i could do my own acceleration thing for this dont know if i will 
        Vector2 inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = (inputVector.normalized) * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //instantiate the fishibgthign
            fishing = true;
        }
        if (inputVector!=Vector2.zero) { fishing = false; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collided");
        if (fishgun.fishInventory[7] < 1)
        {
            Destroy(gameObject);
        }
        fishgun.fishInventory[7] -=1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

    }
}
