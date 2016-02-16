using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {

    Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        target = GameObject.FindWithTag("Player").transform;
        transform.position = new Vector3 (target.position.x, transform.position.y, transform.position.z);
    }
}
