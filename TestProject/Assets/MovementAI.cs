using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAI : MonoBehaviour {

    // Kinematic
    public Vector3 position;
    public float orientation;
    public Vector3 velocity;
    public float rotation;

    // SteeringOutput
    public Vector3 linear;
    public float angular;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        position += velocity * Time.deltaTime;
        orientation += rotation * Time.deltaTime;

        velocity += linear * Time.time;
        orientation += angular * Time.time;
	}

    
}
