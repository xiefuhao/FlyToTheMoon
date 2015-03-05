using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

	void Awake()
	{
		EntityManager.Singleton.Register(this);
	}
	void OnDestroy()
	{
		EntityManager.Singleton.Unregister(this);
	}
}
