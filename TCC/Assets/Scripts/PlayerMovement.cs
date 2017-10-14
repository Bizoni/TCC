using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D body;
    Animator anim;
    List<Quest> questCurr;
    bool questTest = false;

	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("inputX", movement.x);
            anim.SetFloat("inputY", movement.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        body.MovePosition(body.position + movement * Time.deltaTime);

        //testando se a função será chamada
        //provavelmente usarei outra classe para tratar as quests e deixar esta apenas para a movimentação
        if(pos.x >= 0 && questTest == false)
        {
            //Está chamando a quest corretamente.
            //Está armazenando na lista corretamente.
            //Está imprimindo o título corretamente.
            Quests.Getmushrooms();
            questTest = true;
            questCurr = Quest.GetQuests();
            QuestDisplay.DisplayQuest(questCurr);
            
        }
    }
}
