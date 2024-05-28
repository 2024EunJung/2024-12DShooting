using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ㅊ갸 : MonoBehaviour
{
    public float LimitTime;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitTime += Time.deltaTime;
        timerText.text = Mathf.RoundToInt(LimitTime) + "초";
    }
}
    