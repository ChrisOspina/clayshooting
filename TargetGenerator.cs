using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{

    public Rigidbody pigeon;
    public Transform launchpoint;
    //public variables
    public float secs_between_launch = 2.0f;
    public float xMinRange = -25.0f;
	public float xMaxRange = 25.0f;
	public float yMinRange = 8.0f;
	public float yMaxRange = 25.0f;
	public float zMinRange = -25.0f;
	public float zMaxRange = 25.0f;
    public GameObject[] pigeons; // The pigeons to spawn

    private float nextSpawnTime;


    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time+secs_between_launch;
    }

    void Update(){
        // if time to spawn a new game object
		if (Time.time  >= nextSpawnTime) {
			// Spawn the game object through function below
			GeneratePigeon ();

			// determine the next time to spawn the object
			nextSpawnTime = Time.time+secs_between_launch;
		}	
    }

//When you shout "Pull"
    void GeneratePigeon(){
        Debug.Log("Pull!");

        //randomize spawn
        Vector3 spawnpos;
        spawnpos.x = Random.Range(xMinRange, xMaxRange);
        spawnpos.y = Random.Range(yMinRange, yMaxRange);
        spawnpos.z = Random.Range(zMinRange,zMaxRange);

        //determine which one to spawn
        int pigeonToSpawn = Random.Range (0, pigeons.Length);
        //actually spawn the object
        GameObject spawnedPigeon= Instantiate (pigeons [pigeonToSpawn], spawnpos, transform.rotation);
        //spawnedPigeon.AddComponent<Rigidbody>();

        Rigidbody rb = spawnedPigeon.GetComponent<Rigidbody>();
        rb.velocity = launchpoint.TransformDirection(Vector3.forward *10f);

        // make the parent the spawner so hierarchy doesn't get super messy
		spawnedPigeon.transform.parent = gameObject.transform;

    }
}
