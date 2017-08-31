using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBalloon : MonoBehaviour {

    public GameObject Balloon;
    public float TimeToRespawn;
    private const float y = -4.6f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("StartGame", TimeToRespawn, TimeToRespawn);
    }

    private void StartGame()
    {
        float x = UnityEngine.Random.Range(-2.3f, 2.3f);
        StartCoroutine(CreateBalloon());        
        Instantiate(Balloon, new Vector3(x, y), Quaternion.identity);        
    }

    // Update is called once per frame
    void Update () {
        
	}

    IEnumerator CreateBalloon(){
        yield return new WaitForSeconds(10);
    }
}
