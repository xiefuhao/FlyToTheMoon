using UnityEngine;
using System.Collections;

public class WeaponPlatform : Entity 
{

	Vector3 m_weaponSlot = new Vector3(0,0,0);


	void Start () 
	{
		
	}
	public void AttachWeaponToSlot(Weapon weapon)
	{
		weapon.gameObject.transform.parent = this.gameObject.transform;
		weapon.gameObject.transform.localPosition = m_weaponSlot;
		weapon.gameObject.transform.localRotation = Quaternion.identity;
	}
	public void PlacePlatform(Vector3 pos)
	{
		m_weaponSlot = pos;
	}
}
