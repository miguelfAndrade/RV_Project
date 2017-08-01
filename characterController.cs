using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	public bool temBilhete;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		temBilhete = false;
		//temBilhete = true;
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;

		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);			
	}

	public void palcoPrincipal()
	{
		Vector3 pos =  new Vector3 (324, 11, 128);
		transform.position = pos;
	}

	public void parqueCampismo()
	{
		Vector3 pos =  new Vector3 (447, 12, 384);
		transform.position = pos;
	}

	public void entrada()
	{
		Vector3 pos =  new Vector3 (151, 42, 59);
		transform.position = pos;
	}

	public void bilheteira()
	{
		Vector3 pos =  new Vector3 (67, 42, 57);
		transform.position = pos;
	}

	public void palcoJazz()
	{
		Vector3 pos =  new Vector3 (346, 6, 454);
		transform.position = pos;
	}

	public void palcoSecundario()
	{
		Vector3 pos =  new Vector3 (287, 19, 259);
		transform.position = pos;
	}

	public void rechargePoint()
	{
		Vector3 pos =  new Vector3 (186, 35, 254);
		transform.position = pos;
	}

	public void estudioVodafone()
	{
		Vector3 pos =  new Vector3 (240, 27, 157);
		transform.position = pos;
	}

	public void areaImprensa()
	{
		Vector3 pos =  new Vector3 (240, 42, 47);
		transform.position = pos;
	}

	public void areaVip()
	{
		Vector3 pos =  new Vector3 (286, 18, 210);
		transform.position = pos;
	}

	public void restauracao()
	{
		Vector3 pos =  new Vector3 (152, 39, 183);
		transform.position = pos;
	}

	public void rechargeCenter()
	{
		Vector3 pos =  new Vector3 (457, 11, 428);
		transform.position = pos;
	}

	public void wc()
	{
		Vector3 pos =  new Vector3 (124, 40, 231);
		transform.position = pos;
	}
}
