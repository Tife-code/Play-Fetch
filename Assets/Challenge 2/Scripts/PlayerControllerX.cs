using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogIn = 0f, dogOut = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
       if (Input.GetKeyDown(KeyCode.Space) && Time.time > dogIn)
        {
            dogIn = Time.time + dogOut;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
