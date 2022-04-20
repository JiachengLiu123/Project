using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get: MonoBehaviour
{
	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Food")
		{
			Destroy(collider.gameObject);
		}
	}
}
