using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 50.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;



    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        
    }

    // Update is called once per frame
    void Update () {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "musuh"){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}