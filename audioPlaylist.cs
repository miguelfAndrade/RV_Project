using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlaylist : MonoBehaviour {

	public AudioClip[] musicas;
	private AudioSource audioSource;


	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		//audioSource = FindObjectsOfType<AudioSource> ();
		/*for(int i = 0; i<audioSource.Length; i++)
		{
			audioSource[i].loop = false;
		}*/
		audioSource.loop = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!audioSource.isPlaying) 
		{
			audioSource.clip = getRandom ();
			audioSource.Play ();
		}

	}

	private AudioClip getRandom()
	{
		return musicas [Random.Range (0, musicas.Length)];
	}
}
