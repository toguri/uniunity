using UnityEngine;
using System.Collections;

public class HogeScript : MonoBehaviour {
	float rollX;

	// Use this for initialization
	void Start () {
		rollX = 0.0f;

	}

	// Update is called once per frame
	void Update () {
		rollX += Time.deltaTime * 360.0f;
		transform.rotation = Quaternion.Euler (rollX, 0, 0);

		transform.position = new Vector3 (-206.4392f, -89.64253f, -133.1152f);
	}
}
