using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectKeyPress : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Button1.SetActive(true);
            Button2.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
