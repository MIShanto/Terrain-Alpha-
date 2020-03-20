using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forCamera : MonoBehaviour {

	Camera my_cam;
	
	float default_fov;
	[SerializeField] float zoomPower_X = 2f;

	void Start()
	{
		
		my_cam = GetComponent<Camera>();
		default_fov = my_cam.fieldOfView;
	}
	void Update()
	{
		

		if (Input.GetButton("Zoom"))
		{
			my_cam.fieldOfView = default_fov / zoomPower_X;
		}
		else
			my_cam.fieldOfView = default_fov;
	}
}
