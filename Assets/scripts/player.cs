using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Animations;

public class player : MonoBehaviour
{
    public deathscreen brogotmurked;
    public Camera cam;
    public GameObject swotrmxfisjfk;
    public float speed;
    public fishshooter fishgun;
    public float score;
    public Rigidbody2D rb;
    public int hooks;
    public Vector2 inputVector;
    private Vector3 offset = new Vector3 (0, 0, -10);

    // Update is called once per frame
    void Update()
    {
        score = Time.deltaTime;
        //i could do my own acceleration thing for this dont know if i will 
        //no i wont
        inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = (inputVector.normalized) * speed;
    }
    private void LateUpdate()
    {
        cam.transform.position = transform.position + offset;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "wall")
        {
            print("collided");
            if (fishgun.fishInventory[7] <= 0)
            {
                brogotmurked.dead();
                Destroy(gameObject);
            }
            else
            {
                Instantiate(swotrmxfisjfk, transform);
            }
            fishgun.fishInventory[7] -= 1;
        }

    }

}
