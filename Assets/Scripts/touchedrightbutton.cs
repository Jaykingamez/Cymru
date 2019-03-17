using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchedrightbutton : MonoBehaviour {

    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine("Bye");

        }
        
    }

    IEnumerator Bye()
    {
        yield return new WaitForSeconds(8f);
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

  
}
