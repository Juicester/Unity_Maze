using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;
using System.Timers;

public class goal : MonoBehaviour {

	public Text collectText;
	public Text nextText;
	public Text winText;
	public Image scary;
	public bool key;
	Stopwatch timer;
	public int time;

	// Use this for initialization
	void Start () {
		key = false;
		collectText.enabled = true;
		nextText.enabled = false;
		winText.enabled = false;
		scary.enabled = false;
		time = 0;


	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "goldKey") {
			

			key = true;

			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "silverKey") {
			collectText.enabled = false;
			nextText.enabled = true;
			time = 0;
			scary.enabled = true;

			Destroy (other.gameObject);

		}

		if (other.gameObject.tag == "hinge1" && key) {
			Destroy (other.gameObject);
			//other.transform.localRotation = Quaternion.Euler (0, 1, 0) * other.transform.localRotation;
		}
		if (other.gameObject.tag == "winBox") {
			winText.enabled = true;
			nextText.enabled = false;

		}
	}


	// Update is called once per frame
	void Update () {

		if (scary.enabled == true) {
			
			time++;

			if (time >= 50 && scary.enabled == true) {
				scary.enabled = false;
			}
		}
		//this.transform.localRotation = Quaternion.Euler (0, 1, 0) * this.transform.localRotation;
	}
}