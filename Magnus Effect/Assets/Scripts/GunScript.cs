using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

	[SerializeField]
	private GameObject bullet;

	[SerializeField]
	private Transform bulletStartPos;

	[SerializeField]
	private float force;
	[SerializeField]
	private float deltaTime = 1f;

	private float _time;

	private void Awake()
	{
		_time = Time.time;
	}

	void Update()
	{
		if (Time.time - _time > deltaTime)
		{
			GameObject go = (GameObject)Instantiate(bullet, bulletStartPos.position, Quaternion.identity);
			go.GetComponent<Rigidbody>().AddForce(Vector3.right * force, ForceMode.Impulse);
			_time = Time.time;
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			GameObject go = (GameObject)Instantiate(bullet, bulletStartPos.position, Quaternion.identity);
			go.GetComponent<Rigidbody>().AddForce(Vector3.right * force, ForceMode.Impulse);
		}
	}

}
