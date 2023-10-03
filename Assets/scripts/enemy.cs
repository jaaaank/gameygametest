using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    private Vector3 target;
    public GameObject player;
    public float speed;
    public SpriteRenderer sprite;

    private void Start()
    {
        //SICK i will say referencing other gameobjects/nodes is way easier in unity than in godot 
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if (player != null)
        {
            target = player.transform.position;
        }
        if (target.x - transform.position.x >= 0)
        {
            sprite.flipX = true;
        }
        if (target.x - transform.position.x < 0)
        {
            sprite.flipX = false;
        }
        float AngleRad = Mathf.Atan2(target.y - transform.position.y, target.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        sprite.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
