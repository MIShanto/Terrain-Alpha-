using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter : MonoBehaviour {

	[SerializeField] AudioClip heliSound;
	private AudioSource my_audioSource;
	bool called;

	// Use this for initialization
	void Start () {
		my_audioSource = GetComponent<AudioSource>();
		called = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.H) && called == false)
		{
			Debug.Log("heli is coming");
			my_audioSource.Play();
			called = true;
		}
	}
}
