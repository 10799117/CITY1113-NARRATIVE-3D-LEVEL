using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using PlayerControllerNamespace;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

   public PlayerController Player;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.StartConversation(myConversation);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Player.IsInDialogue = true;
            }

            

        }
    }


}
