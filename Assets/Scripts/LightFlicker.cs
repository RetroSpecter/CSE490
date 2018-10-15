using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

    public Light tvLight;
    public Vector2 flickerRange;
    public float flickerRate;

	// Use this for initialization
	void Start () {
        InvokeRepeating("flicker", 0, flickerRate);
	}

    void flicker() {
        tvLight.intensity = Random.Range(flickerRange.x, flickerRange.y);
    }
}
