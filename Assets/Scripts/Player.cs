using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public GameObject ProjectilePlayerPrefab;
    public float speed = 2.0f;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            speed = 20.0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector2 spawnPosition = this.transform.position;
                GameObject mustdestroy = Instantiate(ProjectilePlayerPrefab, spawnPosition, Quaternion.identity);
                Destroy(mustdestroy, 10f);
                mustdestroy.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 10f);
            }
        }
    }
}
