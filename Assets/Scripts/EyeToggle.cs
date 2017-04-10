using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeToggle : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			StereoTargetEyeMask temp = cam1.stereoTargetEye;
			cam1.stereoTargetEye = cam2.stereoTargetEye;
			cam2.stereoTargetEye = temp;
		}
	}
}
