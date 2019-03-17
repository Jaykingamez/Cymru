using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour {

    private void Start()
    { 
       
    }

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(5f);
        Application.Quit();
    }
}
