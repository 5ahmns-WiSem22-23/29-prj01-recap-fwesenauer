using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    public int counter = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Present")
        {
            counter++;
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
