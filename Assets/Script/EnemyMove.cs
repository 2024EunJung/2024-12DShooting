using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    Transform tr;
    public float speed;
    public int health;
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
        yield return new WaitForSeconds(15.0f);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            BulletMove bullet = collision.gameObject.GetComponent<BulletMove>();
            OnHit(bullet.dmg);
            Destroy(collision.gameObject);
        }
    }

    void OnHit(int dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            GameObject.Find("GameManager").GetComponent<Score>().score += 10;
            Destroy(gameObject);
        }
    }
}
