using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 다시하기 : MonoBehaviour
{

    public Text timeText;
    public Text scoreText;
    public GameObject gameOverPanel; 
    public Button restartButton;


    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
