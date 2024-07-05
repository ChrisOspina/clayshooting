using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public GameObject playerCam;
    public AudioClip shootsound;
    public ParticleSystem gunsmoke;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region raycasting
        RaycastHit ThingIhit;

        if(Physics.Raycast(playerCam.transform.position,playerCam.transform.TransformDirection(Vector3.forward),out ThingIhit)){
            Debug.DrawRay(transform.position,transform.TransformVector(Vector3.forward)*ThingIhit.distance, Color.yellow);
        }

        #endregion
    }
}
