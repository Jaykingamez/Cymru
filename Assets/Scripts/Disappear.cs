using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Gone");
	}
	
	IEnumerator Gone()
    {
        yield return new WaitForSeconds(8f);
        this.gameObject.SetActive(false);
    }
}
