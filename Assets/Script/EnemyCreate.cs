using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    public GameObject prefabEnemy;

    public Transform[] spawnPoints;
    public GameObject[] enemyObjs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator CreateEnemy()
    {
        while (true)
        {
            int ranEnemy = Random.Range(0, 5);  //��� �� ��ȯ����
            int ranPoint = Random.Range(0, 5);  //��������Ʈ ��ġ

            Instantiate(enemyObjs[ranEnemy],
                        spawnPoints[ranPoint].position/*creatingPoint*/, Quaternion.identity);

            float creatingTime = Random.Range(0.3f, 1.5f);
            yield return new WaitForSeconds(creatingTime);
        }
    }
}
