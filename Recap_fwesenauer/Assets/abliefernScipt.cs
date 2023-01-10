using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abliefernScipt : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float xMin = -20.0f;
    public float xMax = 20.0f;
    public float yMin = -20.0f;
    public float yMax = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goal")
        {
            Debug.Log("abgeliefert");

            SpawnObject();

            Destroy(gameObject);
        }
    }

    void SpawnObject()
    {
        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);
        Vector2 spawnPosition = new Vector2(x, y);
        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }
}
