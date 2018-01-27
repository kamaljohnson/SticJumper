using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    // Use this for initialization
    bool isUp;
    bool flag;
    Transform playerTransform;
    Rigidbody player;
	void Start () {
        isUp = false;
        flag = true;
        player = GetComponent<Rigidbody>();
        playerTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Jump")>0)
        {
            isUp = true;
        }
        else
        {
            isUp = false;
        }
		if(isUp)
        {
            Debug.Log("Moving");
            float rotate = -250;
            if (flag)
            {
                Vector3 force = new Vector3(700, 1600, 0);
                player.AddForce(force);
                flag = false;
            }
            playerTransform.Rotate(0, rotate*Time.deltaTime, 0);
        }
        
	}
}
