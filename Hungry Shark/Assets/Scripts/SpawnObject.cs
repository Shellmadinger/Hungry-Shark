using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {
    //Initializing Variables
    public GameObject asset;
    public GameObject otherAsset;
    public Transform spawnPoint;
    public float minTime;
    public float maxTime;
    int choiceAsset;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnFish());
    }

    IEnumerator SpawnFish()
    {
       while (true)
        {
            
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            choiceAsset = Random.Range(1,6);
            if (choiceAsset == 1 || choiceAsset == 2)
            {
                GameObject fish = Instantiate(asset, spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }
           
            else
            {
                GameObject fish = Instantiate(otherAsset, spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }

            Debug.Log(choiceAsset);
        }
       
    }
}
