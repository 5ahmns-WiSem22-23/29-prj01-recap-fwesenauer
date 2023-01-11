using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentCollect : MonoBehaviour
{
    public Text playerStatus;
//present sammeln
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Present")
        {
            Debug.Log("triggert");
            // Attach the object to the player
            collision.gameObject.transform.SetParent(transform);

            playerStatus.text = "Present collected";
        }

    }

 
}
