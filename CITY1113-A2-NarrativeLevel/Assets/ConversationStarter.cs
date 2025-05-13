using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

    public GameObject FPSController;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FPScontroller.GetComponent<FPSController>().enabled = false;
                ConversationManager.Instance.StartConversation(myConversation);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
               
            }
        }
    }


}
