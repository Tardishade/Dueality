using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {


    public float freq;

    public float red;
    public float green;
    public float blue;

    // Use this for initialization
    void Start () {
        var col = GetComponentInChildren<SpriteRenderer>().color;
        red = col.r;
        green = col.g;
        blue = col.b;

        print(red+ " " + green + " " + blue);

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetFloat("freq", freq);

        PlayerPrefs.SetFloat("red", red);
        PlayerPrefs.SetFloat("green", green);
        PlayerPrefs.SetFloat("blue", blue);


        Resources.Load<Material>("CircleMat").color =
               //GetComponentInChildren<TrailRenderer>().material.color = 
               new Color(
               PlayerPrefs.GetFloat("red"),
               PlayerPrefs.GetFloat("green"),
               PlayerPrefs.GetFloat("blue"));
    }
}
