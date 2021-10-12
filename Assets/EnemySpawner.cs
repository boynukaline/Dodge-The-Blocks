using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private Transform _EnemyPrefab;
    [SerializeField]
    private Transform[] _enemySpawnPoint;
    private Transform block;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EnemySpawn");

    }


    IEnumerator EnemySpawn()
    {

        yield return new WaitForSeconds(1f);

        int dontSpawn = Random.Range(0, 3);

        for (int i = 0; i < 3; i++)
        {
            if (i != dontSpawn)
            {
                block = Instantiate(_EnemyPrefab, _enemySpawnPoint[i].position, Quaternion.identity);
                block.SetParent(transform);
            }
        }

        while (true)
        {

            dontSpawn = Random.Range(0, 3);
            while (block.transform.position.y < -2f)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i != dontSpawn)
                    {
                        block = Instantiate(_EnemyPrefab, _enemySpawnPoint[i].position, Quaternion.identity);
                        block.SetParent(transform);
                    }
                }

            }

            yield return null;
        }
    }
}
