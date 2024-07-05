using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonScript : MonoBehaviour
{
    public int pointValue;
    public int speed;

    public GameObject explosionPrefab;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision newCollision){
        if (newCollision.gameObject.tag == "Projectile") {
			if (explosionPrefab) {
				// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate (explosionPrefab, transform.position, transform.rotation);
			}
				
			// destroy the projectile
			Destroy (newCollision.gameObject);
				
			// destroy self
			Destroy (gameObject);
		}
	}
    }
