using UnityEngine;
using System.Collections;

public class SPIN : MonoBehaviour {
	int zz;
	// Use this for initialization
	void Start () {
		zz = Random.Range (-200, 200);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, 0, zz * Time.deltaTime);
	}
}
