using UnityEngine;
using System.Collections;

public class Weapon : Entity {

	Entity m_owner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Fire()
	{
		GameObject.Instantiate(Resources.Load("Entities/Bullet"),transform.position,Quaternion.identity);
	}
}
