using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slideShow : MonoBehaviour {

	public Sprite[] imagens;
	private Image img;

	private int i;

	void Start()
	{
		i = 0;
		img = GetComponent<Image> ();
		img.sprite  = imagens[i];
	}

	void Update()
	{
		
		if (i > (imagens.Length - 1)) 
		{
			i = 0;
			img.sprite = imagens [i];
		} 
		else if (i < 0) 
		{
			i = (imagens.Length - 1);
			img.sprite = imagens [i];
		}
		else
		{
			img.sprite = imagens [i];
		}
		//img.sprite = imagens [Random.Range (0, imagens.Length)];
	}

	public void frente()
	{
		Debug.Log ("mais");
		i++;

	}

	public void tras()
	{
		Debug.Log ("menos");
		i--;

	}
}
