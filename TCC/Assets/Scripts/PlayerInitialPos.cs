using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInitialPos : MonoBehaviour {

    int previousLevel;
    int tempPos;

    // Use this for initialization
    void Start() {

        previousLevel = PlayerPrefs.GetInt("previousScene");
        Debug.Log(previousLevel);
        if (0 == previousLevel)
        {
            GameObject.Find("player").transform.position = new Vector3(0.29f, 1.55f, -1);
        }
        else if (1 == previousLevel)
        {
            Debug.Log("oi");
            GameObject.Find("player").transform.position = new Vector3(3.060086f, 0.37f, -1);
        }

    }
	
	// Update is called once per frame
	void Update () {

	}

}
