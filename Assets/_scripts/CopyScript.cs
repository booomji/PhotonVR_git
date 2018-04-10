using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.XR;

public class CopyScript : Photon.MonoBehaviour {

    // public Camera myCam;

    void Start()
    {
        if (photonView.isMine)
        {
            GetComponent<PhotonVoiceRecorder>().enabled = true;
            //GetComponent<AudioSource>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (photonView.isMine)
        {
            transform.rotation = Camera.main.transform.rotation; //myCam.transform.rotation;
        }
		
	}
}
