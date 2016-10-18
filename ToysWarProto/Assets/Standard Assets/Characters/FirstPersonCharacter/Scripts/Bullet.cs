using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

	void Start()
	{
		Destroy(gameObject, 2);
	}

	void Update ()
	{
		transform.position += transform.up * Time.deltaTime * 20;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Enemy") {
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}
	}

}

