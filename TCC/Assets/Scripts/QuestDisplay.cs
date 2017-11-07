using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestDisplay : MonoBehaviour {

    // TODO: Criar uma funcao de prompt quest que vai mostrar os botoes, essa funcai vai ser a responsavel por setar uma outra variavel que
    // vai controlar se eu tenho uma quest ativa ou nao, para poder ser mostrado quando aperto o q (quest log). essa variavel vai fazer o
    // controle se o personagem tem quest no momento ou nao!
    public static bool haveQuest;
    public static Text qTitle;
    public static Text qDescription;
    public static Text qObjective;
    // private GameObject player;
    private GameObject titleGO;
    private GameObject descriptionGO;
    private GameObject objectiveGO;

    //Buttons
    private static GameObject acceptGO;
    public static Button acceptB;
    private static GameObject declineGO;
    public static Button declineB;

    //Quad
    private static GameObject decline;

    // Use this for initialization
    void Start () {

        haveQuest = false;
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

        acceptGO = GameObject.Find("AcceptButton");
        acceptB = acceptGO.GetComponent<Button>();
        acceptB.interactable = false;
        acceptB.gameObject.SetActive(false);
        declineGO = GameObject.Find("DeclineButton");
        declineB = declineGO.GetComponent<Button>();
        declineB.interactable = false;
        declineB.gameObject.SetActive(false);

        decline = GameObject.Find("Decline");
    }
	
	// Update is called once per frame
	void Update () {

    }

    public static void PromptQuest(List<Quest> newQuest)
    {
        if (!haveQuest)
        {
            acceptB.interactable = true;
            acceptB.gameObject.SetActive(true);
            declineB.interactable = true;
            declineB.gameObject.SetActive(true);

            qTitle.text = newQuest[newQuest.Count - 1].GetTitle();
            qTitle.enabled = true;
            qDescription.text = newQuest[newQuest.Count - 1].GetDescription();
            qDescription.enabled = true;
            qObjective.text = newQuest[newQuest.Count - 1].GetObjective();
            qObjective.enabled = true;
        }
    }
    //Display some text with the quest info
    public static void DisplayQuest(List<Quest> currentQuest)
    {
        if (haveQuest == false)
        {
            qTitle.text = "No Quests yet!";
            qTitle.enabled = true;
        }
        else
        {
            //ManageButton.showButtons();
            //acceptB.interactable = true;
            //acceptB.gameObject.SetActive(true);
            //declineB.interactable = true;
            //declineB.gameObject.SetActive(true);

            qTitle.text = currentQuest[currentQuest.Count - 1].GetTitle();
            qTitle.enabled = true;
            qDescription.text = currentQuest[currentQuest.Count - 1].GetDescription();
            qDescription.enabled = true;
            qObjective.text = currentQuest[currentQuest.Count - 1].GetObjective();
            qObjective.enabled = true;
        }
    }
    public static void HideQuest()
    {
        //ManageButton.hideButtons();
        acceptB.interactable = false;
        acceptB.gameObject.SetActive(false);
        declineB.interactable = false;
        declineB.gameObject.SetActive(false);

        qDescription.enabled = false;
        qObjective.enabled = false;
        qTitle.enabled = false;
    }

    private void OnMouseDown()
    {
        if (!haveQuest)
        {
            acceptB.interactable = false;
            acceptB.gameObject.SetActive(false);
            declineB.interactable = false;
            declineB.gameObject.SetActive(false);

            qDescription.enabled = false;
            qObjective.enabled = false;
            qTitle.enabled = false;

            decline.SetActive(false);
            if (gameObject.name == "Decline")
            {
                PlayerQuestsManager.DeclineQuest();
            }
            else if (gameObject.name == "Accept")
            {
                haveQuest = true;
            }
        }
    }
}
