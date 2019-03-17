using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followposition : MonoBehaviour {

    public GameObject followed;
    private GameObject follower;
    private Vector2 followerposition;

	// Use this for initialization
	void Start () {
        followerposition = this.transform.position;
        followerposition.x = followed.transform.position.x;
        this.transform.position = followerposition;
	}
	
	// Update is called once per frame
	void Update () {
        followerposition.x = followed.transform.position.x;
        this.transform.position = followerposition;
    }
}
