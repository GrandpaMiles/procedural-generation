using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class procedurallevel : MonoBehaviour
{
    List<GameObject> spawnedObjects = new List<GameObject>();
    [SerializeField]
    GameObject sunflower;
    [SerializeField]
    GameObject Banana;
    [SerializeField]
    GameObject Apple;
    [SerializeField]
    GameObject Tree;
    // Start is called before the first frame update
    void Start()
    {
        ShuffleDeck();
    }
    void ShuffleDeck()
    {

        int amountOfSunflowers = Random.Range(0, 10);
        for (int i = 0; i < amountOfSunflowers; i++)
        {
            spawnedObjects.Add(Instantiate(sunflower, new Vector3(Random.Range(0, 100), Random.Range(0, 0), Random.Range(0, 100)), Quaternion.identity));
        }
        int amountOfBanana = Random.Range(0, 10);
        for (int i = 0; i < amountOfBanana; i++)
        {
            spawnedObjects.Add(Instantiate(Banana, new Vector3(Random.Range(0, 100), Random.Range(0, 0), Random.Range(0, 100)), Quaternion.identity));
        }
        int amountOfApple = Random.Range(0, 10);
        for (int i = 0; i < amountOfApple; i++)
        {
            spawnedObjects.Add(Instantiate(Apple, new Vector3(Random.Range(0, 100), Random.Range(0, 0), Random.Range(0, 100)), Quaternion.identity));
        }
        int amountOfTree = Random.Range(0, 10);
        for (int i = 0; i < amountOfTree; i++)
        {
            spawnedObjects.Add(Instantiate(Tree, new Vector3(Random.Range(0, 100), Random.Range(0, 0), Random.Range(0, 100)), Quaternion.identity));
        }
    }
    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.R))
        {

            foreach(GameObject spawnedObject in spawnedObjects)
            {
                Destroy(spawnedObject);
                
            }
            ShuffleDeck();
        }    
    }

}
