using UnityEngine;
using System.Collections;

public class FRCameraController : MonoBehaviour
{
	public Vector3 m_moveDir;
	Entity m_target;
	// Use this for initialization
	void Start () {
		m_target = EntityManager.m_singleton.GetFighter();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position+=m_moveDir;
		Follow(m_target.transform.position+new Vector3(0,0,-50));
	}
	void Follow(Vector3 pos)
	{
		transform.position = Vector3.Lerp(transform.position,pos,0.1f);
	}
}
