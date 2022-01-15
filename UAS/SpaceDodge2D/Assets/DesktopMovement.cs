using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DesktopMovement : MonoBehaviour {
    public Transform player;
    public float speed = 5.0f;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update(){
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if(Input.GetButtonDown("Fire1")){
            shootBullet();
        }
    }

    void moveCharacter(Vector2 direction){
        player.Translate(direction * speed * Time.deltaTime);
    }
    public void shootBullet(){
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;
        }

}