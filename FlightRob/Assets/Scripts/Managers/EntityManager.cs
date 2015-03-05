using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EntityManager : Manager<EntityManager>
{
	
	List<Entity> m_entityList = new List<Entity>();
	Entity m_fighter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Register(Entity entity)
	{
		m_entityList.Add(entity);
		if(entity is Fighter)
			m_fighter = entity;

	}
	public void Unregister(Entity entity)
	{
		m_entityList.Remove(entity);
	}
	public Entity GetFighter()
	{
		return m_fighter;
	}
}
