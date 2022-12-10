using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public PlayerController player;
    public List<PickUp> pickUp;
    public List<string> objectPicked;

    public void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }


    public void AcceptQuest()
    {
        objectPicked = new List<string>(new string[quest.goal.requiredAmount]);
        quest.goal.requiredAmount = pickUp.Count;
        quest.isActive = true;
        //player.quest = quest;
        for(int i=0; i<pickUp.Count; i++)
        {
            pickUp[i].quest = quest;
            pickUp[i].gameObject.SetActive(true);
        }
    }

    public bool CompletedMissionDialogue()
    {
        return quest.completed;
    }
}
