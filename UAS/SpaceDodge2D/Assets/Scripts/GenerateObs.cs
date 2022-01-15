using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour

{
    int score;
    GUIStyle TextStyle = new GUIStyle();
   
   public GameObject rocks;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 7.5f);
    }
    void CreateObstacle()
    {
        Instantiate (rocks);
        ScoreManager.instance.AddPoint();
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
}
