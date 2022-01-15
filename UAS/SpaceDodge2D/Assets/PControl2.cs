using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PControl2 : MonoBehaviour
{
    Vector3 kanan;
    Vector3 kiri;
    Vector3 atas;
    Vector3 bawah;
    Vector3 maju;
    Vector3 mundur;
    public float speed;
    private Rigidbody2D rigidbody;
    
    
    static Quaternion toQuaternion (Vector3 euler) 
    {
        Quaternion q;
        float pitch = euler.y;
        float roll = euler.x;
        float yaw = euler.z;
        float t0 = Mathf.Cos(yaw * 0.5f);
        float t1 = Mathf.Sin(yaw * 0.5f);
        float t2 = Mathf.Cos(roll * 0.5f);
        float t3 = Mathf.Sin(roll* 0.5f);
        float t4 = Mathf.Cos(pitch * 0.5f);
        float t5 = Mathf.Sin(pitch * 0.5f);
        Debug.Log (t0 + " " + t1 + " " + t2 + " " + t3 + " " + t4 + " " + t5 + " ");

        q.x = t0 * t3 * t4 - t1 * t2 * t5;
        q.y = t0 * t2 * t5 + t1 * t3 * t4;
        q.z = t1 * t2 * t4 - t0 * t3 * t5;
        q.w = t0 * t2 * t4 + t1 * t3 * t5;
        return q;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        kanan = new Vector3(1,0,0);
        kiri = new Vector3(-1,0,0);
        atas = new Vector3(0,1,0);
        bawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("right")){
            transform.position = transform.position + (kanan * speed * Time.deltaTime);
        }
        if(Input.GetKey("left")){ 
            transform.position = transform.position + (kiri * speed * Time.deltaTime);
        }
        if(Input.GetKey("up")){
            transform.position = transform.position + (atas * speed * Time.deltaTime);
        }
        if(Input.GetKey("down")){
            transform.position = transform.position + (bawah * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.rotation = transform.rotation * toQuaternion(maju * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.rotation = transform.rotation * toQuaternion(mundur * speed * Time.deltaTime);
        }

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