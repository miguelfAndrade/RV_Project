using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public characterController player;
	public GameObject pause;
	public GameObject escapeMenu;
	public GameObject cam;
	public camMouseLook c;

	public GameObject aviso;
	public GameObject bilhete;

	float timer;

	// Use this for initialization
	void Start () 
	{
		pause.SetActive (false);
		escapeMenu.SetActive (false);
		aviso.SetActive (false);
		bilhete.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		menuPausa ();
		menuEscape ();
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			timer = 0;
			aviso.SetActive (false);
		}
	}

	void menuPausa()
	{
		if (player.temBilhete) 
		{
			bilhete.SetActive (true);
			if (Input.GetKeyDown (KeyCode.M)) 
			{
				if (!pause.activeInHierarchy) 
				{
					pause.SetActive (true);
					aviso.SetActive (false);
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
					Time.timeScale = 0;
					c.escape = true;
				}
				else 
				{
					pause.SetActive (false);
					aviso.SetActive (false);
					Cursor.lockState = CursorLockMode.Locked;
					Cursor.visible = false;
					Time.timeScale = 1;
					c.escape = false;
				}
			} 
		} 
		else 
		{
			bilhete.SetActive (false);
			if (Input.GetKeyDown (KeyCode.M)) 
			{
				timer = 5.0f;
				Cursor.visible = false;
				aviso.SetActive (true);
				//Debug.Log ("Não pode usar esta funcionalidade agora! Compre Bilhete");
			}
		}
	}

	void menuEscape()
	{
		if(Input.GetKeyDown (KeyCode.Escape))
		{
			if (!escapeMenu.activeInHierarchy) 
			{
				escapeMenu.SetActive (true);
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				Time.timeScale = 0;
				c.escape = true;
			}
			else 
			{
				escapeMenu.SetActive (false);
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				Time.timeScale = 1;
				c.escape = false;
			}
		}
	}

	public void botaoRetomar()
	{
		escapeMenu.SetActive (false);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		Time.timeScale = 1;
		c.escape = false;
	}

	public void botaoMenu(string menu)
	{
		SceneManager.LoadScene (menu);
	}
}
