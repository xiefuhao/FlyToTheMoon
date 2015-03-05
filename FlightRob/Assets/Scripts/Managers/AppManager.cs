using UnityEngine;
using System.Collections;

public class AppManager : Manager<AppManager>
{

		
	public EntityManager 		m_entityManager {get;private set;}
	public InstantiateManager 	m_instantiateManager {get;private set;}

	// Use this for initializationØ
	void Start () {
		DontDestroyOnLoad(gameObject);
		m_entityManager = gameObject.AddComponent<EntityManager>();
		m_instantiateManager = gameObject.AddComponent<InstantiateManager>();
	}
	
	// Update is called once per frame
	void Update () {
		//load to level 1 by default
		if(Application.loadedLevel!=1)
			Application.LoadLevel(1);
	}
}
