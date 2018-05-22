using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class keyRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		this.transform.localRotation = Quaternion.Euler (0, 1, 0) * this.transform.localRotation;
	}
}

