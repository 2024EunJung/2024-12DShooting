using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    Transform tr;
    public float speed;
    public int dmg;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        StartCoroutine(DestorySelf());
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector2.up * speed); //(0,1)
    }

    IEnumerator DestorySelf()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this.gameObject);
    }
}
