using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Quest : MonoBehaviour {

    protected static List<Quest> questList = new List<Quest>();
    public static List<Quest> GetQuests()
    {
        return new List<Quest>(questList);
    }
    public abstract string GetTitle();
    public abstract string GetObjective();
    public abstract string GetDescription();
    //public abstract bool FinishQuest();


    // Use this for initialization
    void Start () {


		
	}

    // Update is called once per frame
    void Update() {

    }

    // Vai receber uma referência para a quest atual e através de um switch case retornar a próxima quest.
    /*
    void NextQuest()
    {
        
    }*/
}
