using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
	[SerializeField]
	private GameObject bulletPrefab;


	void Update ()
	{
		Shoot();
	}

	private void Shoot()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(bulletPrefab, transform.position, transform.rotation);
		}
	}

}

