using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private Transform target;


	// Update is called once per frame
	void Update () {
		
	}

	public void Seek(Transform _target){
		target = _target;
	}
}
