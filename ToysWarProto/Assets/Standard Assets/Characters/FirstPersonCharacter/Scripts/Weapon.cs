using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
	[SerializeField]
	private GameObject bulletPrefab;

	private Transform spawnPoint;

	void Start()
	{
		spawnPoint = transform.FindChild("Spawn");
	}

	void Update ()
	{
		Shoot();
	}

	private void Shoot()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Instantiate(bulletPrefab, spawnPoint.transform.position, transform.rotation);
		}
	}

}

