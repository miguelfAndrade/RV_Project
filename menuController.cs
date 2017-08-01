using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {

	public GameObject instrucoes;
	public GameObject menu;

	public void Start()
	{
		menu.SetActive (true);
		instrucoes.SetActive (false);
	}

	public void comecaVisita(string nomeCena)
	{
		SceneManager.LoadScene (nomeCena);
	}

	public void info()
	{
		menu.SetActive (false);
		instrucoes.SetActive (true);
	}

	public void voltar()
	{
		menu.SetActive (true);
		instrucoes.SetActive (false);
	}

	public void sair()
	{
		Application.Quit ();
	}
}
