﻿using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;
	public GameObject camera3;
	public GameObject mapCamera;
	
	public void EnableCamera1() {
		camera1.SetActive(true);
		camera2.SetActive(false);
		camera3.SetActive(false);
		mapCamera.SetActive(false);
	}
	public void EnableCamera2() {
		camera1.SetActive(false);
		camera2.SetActive(true);
		camera3.SetActive(false);
		mapCamera.SetActive(false);
	}
	public void EnableCamera3() {
		camera1.SetActive(false);
		camera2.SetActive(false);
		camera3.SetActive(true);
		mapCamera.SetActive(false);
	}
	public void EnableMapCamera() {
		camera1.SetActive(false);
		camera2.SetActive(false);
		camera3.SetActive(false);
		mapCamera.SetActive(true);
	}
}