using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public Transform spwanPosition;
	private Transform[] spwanPositions;

	public bool respwan = false;
	private bool toogle = false;
	void Start () {
		spwanPositions = spwanPosition.GetComponentsInChildren<Transform>();
		
		
	}
		
	void Update () {
		if(respwan!=toogle)
		{
			Respwan();
			respwan = false;
		}
		else
		{
			toogle = respwan;
		}
	}
	void Respwan()
	{
		int i = Random.Range(1,spwanPositions.Length);
		
		transform.position = spwanPositions[i].transform.position;

		
	}
}
