using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(DestroySelf());
        }
    }

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(0.01f);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
