using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePowerUp : MonoBehaviour
{
    public string originalName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == originalName)
            {
                gameObject.SetActive(false);
            }
            Debug.Log("hideeee");
        }
    }

  
}
