using UnityEngine;
using System.Collections;

public class Bullet : Entity {

	float startTimeStamp;
	// Use this for initialization
	void Start () {
		startTimeStamp  = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position+=Vector3.right;
		if((Time.time - startTimeStamp)>5)
		{
			Destroy(gameObject);
		}
	}
	void OnCollisionEnter(Collision collision) 
	{
		foreach (ContactPoint contact in collision.contacts) 
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
		//if (collision.relativeVelocity.magnitude > 2)
		//	audio.Play();
		
	}
}
