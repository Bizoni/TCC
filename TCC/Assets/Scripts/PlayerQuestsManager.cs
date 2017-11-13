using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuestsManager : MonoBehaviour {

    static List<Quest> questCurr = default(List<Quest>);
    bool questOnScreen = false;
    bool questTest = false;

    Collider2D playerCollider;
    Collider2D momCollider;

    /*GameObject playerGO;
    GameObject momGO;
    */
    // Use this for initialization
    void Start() {

        playerCollider = GameObject.Find("player").GetComponent<Collider2D>();
        momCollider = GameObject.Find("Mom").GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update() {

        Vector3 pos = transform.position;
        //testando se a função será chamada
        //provavelmente usarei outra classe para tratar as quests e deixar esta apenas para a movimentação
       /* if (pos.x >= 0 && questTest == false)
        {
            //Está chamando a quest corretamente.
            //Está armazenando na lista corretamente.
            //Está imprimindo o título corretamente.
            Quests.Getmushrooms();
            questTest = true;
            questCurr = Quest.GetQuests();
            QuestDisplay.PromptQuest(questCurr);
        }*/

        //displaycurrentQuest
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (questOnScreen == false)
            {
                QuestDisplay.DisplayQuest(questCurr);
                questOnScreen = true;
            }
            else
            {
                QuestDisplay.HideQuest();
                questOnScreen = false;
            }
        }

        if(playerCollider.IsTouching(momCollider) && Input.GetKeyDown(KeyCode.R))
        {
            Quests.Getmushrooms();
            questTest = true;
            questCurr = Quest.GetQuests();
            QuestDisplay.PromptQuest(questCurr);
        }
    }

    public static void DeclineQuest()
    {

        questCurr.RemoveAt(questCurr.Count - 1);

    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
