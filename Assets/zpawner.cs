using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zpawner : MonoBehaviour
{
    public GameObject zombie;
    GameObject zb;
    [SerializeField] float minPos;
    [SerializeField] float maxPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnZombie());
        Destroy(zb, 8);
    }

    IEnumerator spawnZombie()
    {
        Vector3 pos = new Vector3(Random.Range(minPos, maxPos), 5.53f, 0);
        zb = Instantiate(zombie, pos, Quaternion.identity);
        int spawnerTime = Random.Range(1, 3);
        yield return new WaitForSeconds(spawnerTime);
        StartCoroutine(spawnZombie());
    }
}
