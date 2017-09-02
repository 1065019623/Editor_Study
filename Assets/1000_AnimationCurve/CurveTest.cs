using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveTest : MonoBehaviour 
{
    public AnimationCurve m_animationCurve;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = new Vector3(Time.time, m_animationCurve.Evaluate(Time.time), transform.position.z);
        Debug.Log(transform.position + " " + Time.time);
	}
}
