using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int speed = 5;
    public Text playerStatus;
    public GameObject PowerUpObject;

    //boost Variablem
    public float speedBoost = 2f;
    public float duration = 5f;
    private Rigidbody2D rb;

    //obstacle Variablen
    public float slowDown = -2f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(h, v, 0) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            StartCoroutine(SlowDown());
            
        }
      

        if(collision.tag == "PowerUP")
        {
            StartCoroutine(SpeedUp());
            SpawnPowerUp();
            Destroy(PowerUpObject);
        }
    }

    void SpawnPowerUp()
    {
        float x = Random.Range(-20, 20);
        float y = Random.Range(-20, 20);
        Vector2 spawnPosition = new Vector2(x, y);
        Instantiate(PowerUpObject, spawnPosition, Quaternion.identity);
    }
    private IEnumerator SpeedUp()
    {
        rb.velocity *= speedBoost; 
        playerStatus.text = "speedUp";
        yield return new WaitForSeconds(duration); 
        rb.velocity /= speedBoost; 
        playerStatus.text = " ";
    }
    private IEnumerator SlowDown()
    {
        rb.velocity *= slowDown; 
        playerStatus.text = "slowDown";
        yield return new WaitForSeconds(duration); 
        rb.velocity /= slowDown; 
        playerStatus.text = "   ";
    }


}
