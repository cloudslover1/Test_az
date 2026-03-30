using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle_find_check_appearance : MonoBehaviour
{

    [SerializeField] private GameObject objectToSpawn; 
    [SerializeField] private GameObject objectToDisappear; 

    private void OnMouseDown()
    {
        if (objectToSpawn != null)
        {
            GameObject spawnedObject = Instantiate(objectToSpawn);

            
            Vector3 spawnPosition = transform.position;
            spawnPosition.z = 170;
            spawnedObject.transform.position = spawnPosition;

            
            spawnedObject.transform.rotation = transform.rotation;

            
            if (objectToDisappear != null)
            {
                objectToDisappear.SetActive(false);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
