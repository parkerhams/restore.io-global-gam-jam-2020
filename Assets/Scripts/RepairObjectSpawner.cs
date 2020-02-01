using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairObjectSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject repairItemPrefab;

    private float timer = 3.5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            SpawnItem();
            timer = 3.5f;
        }
    }

    private void SpawnItem()
    {
        GameObject repairItemInstance = Instantiate(repairItemPrefab, 
            this.transform.position, Quaternion.identity);
        print("Object instantiated!");
    }
}
