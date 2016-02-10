using UnityEngine;
using System.Collections;

public class tempdeath : MonoBehaviour {

    public float health = 100;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            health += -10;
        }
            
    }
        // Use this for initialization
        void Start () {
	
	}

    // Update is called once per frame
    void Update() {

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
