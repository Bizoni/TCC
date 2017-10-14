using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestDisplay : MonoBehaviour {

    public static Text qTitle;
    public static Text qDescription;
    public static Text qObjective;
    // private GameObject player;
    private GameObject titleGO;
    private GameObject descriptionGO;
    private GameObject objectiveGO;

    // Use this for initialization
    void Start () {
        
        titleGO = GameObject.Find("questTitle");
        qTitle = titleGO.GetComponent<Text>();
        descriptionGO = GameObject.Find("questDescription");
        qDescription = descriptionGO.GetComponent<Text>();
        objectiveGO = GameObject.Find("questObjective");
        qObjective = objectiveGO.GetComponent<Text>();
        //qTitle.text = "";
        qTitle.enabled = false;
        qDescription.enabled = false;
        qObjective.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

    }
    public static void DisplayQuest(List<Quest> currentQuest)
    {
        Debug.Log(currentQuest[currentQuest.Count - 1].GetTitle());
        qTitle.text = currentQuest[currentQuest.Count - 1].GetTitle();
        qTitle.enabled = true;
        qDescription.text = currentQuest[currentQuest.Count - 1].GetDescription();
        qDescription.enabled = true;
        qObjective.text = currentQuest[currentQuest.Count - 1].GetObjective();
        qObjective.enabled = true;
    }
}
