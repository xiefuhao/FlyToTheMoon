using UnityEngine;
using System.Collections;

struct PlayerIuput
{
	public bool forward;
	public bool backward;
	public bool up;
	public bool down;
	public bool fire;
}
public class FRCharactorBehaviour:MonoBehaviour
{
	PlayerIuput m_inputFrame;
	public void Update ()
	{
		m_inputFrame.forward = Input.GetKey(KeyCode.D);
		m_inputFrame.backward = Input.GetKey(KeyCode.A);
		m_inputFrame.up = Input.GetKey(KeyCode.W);
		m_inputFrame.down = Input.GetKey(KeyCode.S);
		m_inputFrame.fire = Input.GetKey(KeyCode.Space);
	
	}
	public bool IsForward()
	{
		return m_inputFrame.forward;
	}
	public bool IsBackward()
	{
		return m_inputFrame.backward;
	}
	public bool IsUp()
	{
		return m_inputFrame.up;
	}
	public bool IsDown()
	{
		return m_inputFrame.down;
	}
	public bool IsFiring()
	{
		return m_inputFrame.fire;
	}
}
