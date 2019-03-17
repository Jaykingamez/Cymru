using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Britain : MonoBehaviour {

    [Header("Projectile Settings")]
    public int numberOfProjectiles;             // Number of projectiles to shoot.
    public float projectileSpeed;               // Speed of the projectile.
    public GameObject ProjectilePrefab;         // Prefab to spawn.
    public float intervals; //Distance between shots

    public Vector2 Playerposition;

    private Vector2 Direction;
    public int Enemyhealth = 50;
    public static Britain instance = null;

    private Vector2 BritainLeftposition;
    private Vector2 BritainRightposition;
    private Vector2 Britainplaceholder;


	// Use this for initialization
	void Start () {
        BritainLeftposition = this.transform.position;
        BritainRightposition = this.transform.position;
        BritainLeftposition.x = -6.06f;
        BritainRightposition.x = 4.58f;
        StartCoroutine("MoveLeftandRight");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator MoveLeftandRight()
    {
        while (true)
        {

            while (this.transform.position.x > -6.06f)
            {
                yield return new WaitForSeconds(0f);
                Britainplaceholder = this.transform.position;
                Britainplaceholder.x -= 0.25f;
                this.transform.position = Britainplaceholder;
            }

            SpawnandShoot();

            while (this.transform.position.x < 4.58f)
            {
                yield return new WaitForSeconds(0f);
                Britainplaceholder = this.transform.position;
                Britainplaceholder.x += 0.25f;
                
                this.transform.position = Britainplaceholder;
            }

            SpawnandShoot();
        }
    }

    void SpawnandShoot()
    {
        Direction = (Playerposition - (Vector2)this.transform.position) * projectileSpeed;
        Vector2 spawnPosition = this.transform.position;
        GameObject mustdestroy = Instantiate(ProjectilePrefab, spawnPosition, Quaternion.identity);
        Destroy(mustdestroy, 10f);

        mustdestroy.GetComponent<Rigidbody2D>().velocity= new Vector2(Direction.x,Direction.y) ;
    }

}
