using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPrefs.SetInt("previousScene", SceneManager.GetActiveScene().buildIndex);
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene("OutsideHouse", LoadSceneMode.Single);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1 && transform.position.x == 3.088f)
        {
            //Debug.Log(PlayerPrefs.GetInt("previousScene"));
            SceneManager.LoadScene("Forest", LoadSceneMode.Single);
        }
    }

}
