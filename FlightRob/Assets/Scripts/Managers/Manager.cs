using UnityEngine;
using System.Collections;

public class Manager<T>:MonoBehaviour  where T :MonoBehaviour
{

	static public T m_singleton;
	
	public static T Singleton
	{
		get
		{
			return m_singleton;
		}
		private set{}
	}
	void Awake()
	{
		m_singleton = GetComponent<T>();
	}
}
