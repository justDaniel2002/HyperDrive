using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemHolder : MonoBehaviour
{
    public GameObject item;
    public float spawnRate;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Ins.isGamePlay)
        {
            if (spawnRate < spawnTime)
            {
                spawnRate += Time.deltaTime;
            }
            if(spawnRate > spawnTime)
            {
                Vector3 spawnPos = new Vector3(Random.Range(-4f, 0f), 8f, 0f);
                Instantiate(item, spawnPos, gameObject.transform.rotation);
                spawnRate = 0;
            }
        }
    }
}
