﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("NextLoading");
	}
	
	IEnumerator NextLoading()
    {
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
