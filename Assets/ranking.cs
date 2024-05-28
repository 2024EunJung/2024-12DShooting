using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Save()
    {
     if (Score == PlayerPrefs.GetInt("BestScore" ))return;
        PlayerPrefs.SetInt("BestScore", Score);
    }
}
