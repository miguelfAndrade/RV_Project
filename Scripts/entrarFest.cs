using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrarFest : MonoBehaviour {

	public characterController player;

	public GameObject textCompra;

	private BoxCollider c;

	void Start () {
		c = GetComponent<BoxCollider>();
		textCompra.SetActive (false);
	}

	void OnTriggerEnter(Collider other)
	{
		if (player.temBilhete) 
		{
			c.isTrigger = true;
			textCompra.SetActive (false);
		} 
		else 
		{
			textCompra.SetActive (true);
		}
	}
		
	void OnTriggerExit(Collider other)
	{
		textCompra.SetActive (false);
	}
}
