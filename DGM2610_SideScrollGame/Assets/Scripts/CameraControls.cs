using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
	private Camera _main;
	private Vector3 _pos;

	public bool CanRun { get; set; }
	private WaitForFixedUpdate _fixed;

	public FloatData CameraSpeed;

	void Start()
	{
		_main = Camera.main;
	}
	
	private IEnumerator RunCoroutine()
	{
		_fixed = new WaitForFixedUpdate();
		yield return _fixed;
        
		while (CanRun)
		{
			yield return _fixed;
            
			_pos.x = CameraSpeed.value * Time.deltaTime;
		}
	}

	public void DisableCam()
	{
		CanRun = false;
		StopCoroutine(RunCoroutine());

	}
}
