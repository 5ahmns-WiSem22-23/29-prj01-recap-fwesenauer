using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentCollect : MonoBehaviour
{
//present sammeln
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Present")
        {
            Debug.Log("triggert");
            // Attach the object to the player
            collision.gameObject.transform.SetParent(transform);
        }

    }

 
}
