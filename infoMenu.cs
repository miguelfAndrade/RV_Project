using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoMenu : MonoBehaviour {

	public characterController player;
	public camMouseLook cam;
	public GameObject info;
	public GameObject textC;

	public bool entrou;

	// Use this for initialization
	void Start () {
		textC.SetActive (false);
		info.SetActive (false);
		entrou = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (entrou) 
		{
			if (Input.GetKeyDown(KeyCode.I))
			{
				if (!info.activeInHierarchy) 
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
					textC.SetActive (false);
					info.SetActive (true);
					Time.timeScale = 0;
					cam.escape = true;
				}
				else
				{
					Cursor.lockState = CursorLockMode.Locked;
					Cursor.visible = false;
					textC.SetActive (true);
					info.SetActive (false);
					Time.timeScale = 1;
					cam.escape = false;
				}
			}
		}	
	}

	void OnTriggerEnter(Collider other)
	{
		entrou = true;
		textC.SetActive (true);
	}

	void OnTriggerExit(Collider other)
	{
		entrou = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		textC.SetActive (false);
		Time.timeScale = 1;
	}
}
