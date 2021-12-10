using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	void Start()
	{
		transform.position = new Vector3(-2.7f, 19.6f, -14.8f);
		transform.position = new Vector3(17f, 19.6f, -14.1f);
		transform.position = new Vector3(-1.4f, 19.6f, -9.7f);
		transform.position = new Vector3(8.1f, 19.6f, -2.1f);
		transform.position = new Vector3(7.6f, 19.6f, -37.7f);
		transform.position = new Vector3(6.1f, 19.6f, -57.2f);
		transform.position = new Vector3(-3.9f, 19.6f, -69.2f);
	}
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
