using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform player;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            shootBullet();
        }
    }
    public void shootBullet(){
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;
    }
}
