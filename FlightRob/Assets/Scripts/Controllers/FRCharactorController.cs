using UnityEngine;
using System.Collections;

public class FRCharactorController : MonoBehaviour {
	Camera camera;
	FRCharactorBehaviour m_behaviour ;//= new FRCharactorBehaviour();
	Vector3 m_desireVelocity;
	float speedMultiplier = 0.3f;
	float cruiseSpeed = 10;
	// Use this for initialization
	void Start ()
	{
		//transform.localPosition = Vector3.zero;
		camera = UnityEngine.Camera.allCameras[0];
		m_behaviour = gameObject.GetComponent<FRCharactorBehaviour>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		m_behaviour.Update();
		m_desireVelocity = Vector3.zero;
		if(m_behaviour.IsForward())
		{
			m_desireVelocity +=cruiseSpeed*new Vector3(1,0,0);
		}
		if(m_behaviour.IsBackward())
		{
			m_desireVelocity += cruiseSpeed*new Vector3(-1,0,0);
		}
		if(m_behaviour.IsUp())
		{
			m_desireVelocity += cruiseSpeed*new Vector3(0,1,0);
		}
		if(m_behaviour.IsDown())
		{
			m_desireVelocity += cruiseSpeed*new Vector3(0,-1,0);
		}

		if(!OutOfCamera(transform.position+m_desireVelocity*Time.deltaTime))
		{
			transform.position+=transform.forward*cruiseSpeed*Time.deltaTime;
		}

	}

	bool OutOfCamera(Vector3 point)
	{
		Vector3 viewPortPoint = camera.WorldToViewportPoint(point);
		if(viewPortPoint.x>1||viewPortPoint.x<0||viewPortPoint.y>1||viewPortPoint.y<0)
			return true;
		return false;
	}
}
