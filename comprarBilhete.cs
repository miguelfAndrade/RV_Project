using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprarBilhete : MonoBehaviour {

	public characterController player;

	public camMouseLook cam;

	public GameObject b;
	public GameObject textC;


	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.Locked;
		textC.SetActive (false);
		b.SetActive (false);
	}	

	void OnTriggerEnter(Collider other)
	{
		textC.SetActive (true);
	}

	void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown (KeyCode.C))
		{
			if (!b.activeInHierarchy) 
			{
				textC.SetActive (false);
				b.SetActive (true);
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				Time.timeScale = 0;
				cam.escape = true;
			}
			else 
			{
				b.SetActive (false);
				textC.SetActive (true);
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				Time.timeScale = 1;
				cam.escape = false;
			}
		}
	}

	void OnTriggerExit(Collider other)
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		textC.SetActive (false);
	}

	public void compra()
	{
		player.temBilhete = true;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		textC.SetActive (true);
		b.SetActive (false);
		Time.timeScale = 1;
		cam.escape = false;
	}
}
