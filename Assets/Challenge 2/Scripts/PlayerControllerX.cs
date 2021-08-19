using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool stateDog = true;
    private float timeSpawnDog = 2;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (stateDog) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                stateDog = false;
                Invoke("allowDogSpawn", timeSpawnDog);
            }
        }
    }

    void allowDogSpawn() {
        stateDog = true;
    }
}
