using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    int score;
    public Vector2 jumpforce = new Vector2(0,300);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float touchclicked = Input.GetAxis ("Fire1");
        if (touchclicked == 1f)
         {
            GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
            GetComponent<Rigidbody2D> ().AddForce(jumpforce);

        } 
        
        Vector2 screenPosition =
        Camera.main.WorldToScreenPoint(transform.position);
        
        if (screenPosition.y > Screen.height || screenPosition.y < 0) Die ();
        
    }
    void Die()
        {
            Debug.Log("game over");
            SceneManager.LoadScene ("Menu");
        }
    void OnCollisionEnter2D(Collision2D coll)
        {
            Die ();
        }
    
}
