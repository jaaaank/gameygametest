using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathscreen : MonoBehaviour
{
    public Camera camcam;
    public Text texttext;
    public player playr;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
      camcam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

    }

    public void dead()
    {
        texttext.text = "You survived for: " + (timer%60).ToString() + " seconds";
        camcam.enabled = true;
    }
}
