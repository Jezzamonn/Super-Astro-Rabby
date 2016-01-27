using UnityEngine;
using System.Collections;

public class JumpAndJive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Random.onUnitSphere;
	}
}
