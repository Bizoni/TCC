using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : Quest
{

    private static string title;
    private static string description;
    private static string objective;

    public override string GetTitle() { return title; }
    public override string GetDescription() { return description; }
    public override string GetObjective() { return objective; }


    // Use this for initialization
    void Start()
    {
        questList = default(List<Quest>);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Quests(string newTitle, string newDescription, string newObjective)
    {
        title = newTitle;
        description = newDescription;
        objective = newObjective;
    }

    public static void Getmushrooms()
    {
        title = "Primeira quest";
        objective = "Colete alguns cogumelos na floresta.";
        description = "vai lá na floresta e pega os cogumelos!";
        questList.Add(new Quests(title, description, objective));
    }
    /*public static void DeclineQuest(List<Quest> currentQuest)
    {
        currentQuest.RemoveAt(currentQuest.Count - 1);
    }*/
}
