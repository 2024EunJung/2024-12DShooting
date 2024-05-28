using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    Transform tr;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        StartCoroutine(DestorySelf());
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector2.down * speed); //(0,1)
    }

    IEnumerator DestorySelf()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            GameObject.Find("GameManager").GetComponent<Score>().score += 10;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
