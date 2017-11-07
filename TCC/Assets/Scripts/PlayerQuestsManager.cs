using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuestsManager : MonoBehaviour {

    static List<Quest> questCurr = default(List<Quest>);
    bool questOnScreen = false;
    bool questTest = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        Vector3 pos = transform.position;
        //testando se a função será chamada
        //provavelmente usarei outra classe para tratar as quests e deixar esta apenas para a movimentação
        if (pos.x >= 0 && questTest == false)
        {
            //Está chamando a quest corretamente.
            //Está armazenando na lista corretamente.
            //Está imprimindo o título corretamente.
            Quests.Getmushrooms();
            questTest = true;
            questCurr = Quest.GetQuests();
            QuestDisplay.PromptQuest(questCurr);
        }

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
    }

    public static void DeclineQuest()
    {

        questCurr.RemoveAt(questCurr.Count - 1);

    }

}
