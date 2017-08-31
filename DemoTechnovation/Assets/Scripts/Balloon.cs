using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > 7)
        {
            Destroy(this.gameObject);
            Debug.Log(this.transform.position.y);
        }

    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
