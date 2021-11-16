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
        score++;
    }
    void OnGUI()
    {
        TextStyle.normal.textColor = Color.white;
        GUI.Label (new Rect (10, 10, 200, 80), "Score: " + score.ToString(), TextStyle);
    }
   
    

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
}
