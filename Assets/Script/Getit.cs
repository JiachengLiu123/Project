using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getit : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Food")
		{
			Destroy(collision.collider.gameObject);
		}
	}
}
