using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

	void Start()
	{
		Destroy(gameObject, 1);
	}

	void Update ()
	{
		transform.position += transform.up * Time.deltaTime * 20;
	}

}

