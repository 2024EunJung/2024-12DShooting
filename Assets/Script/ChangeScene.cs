using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToGameScene()
    {
        SceneManager.LoadScene("InGame");
    }
    public void GoToStartScene()
    {
        SceneManager.LoadScene("GameStart");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameOver")
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("InGame");
            }
        }
    }
}
