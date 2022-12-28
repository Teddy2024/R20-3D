using UnityEngine;
using UnityEngine.Events;

namespace Teddy
{
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後事件")]
        private UnityEvent onDialogueFinish;


        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake() 
        {
            dialogueSystem = GameObject.Find("TalkCanvas").GetComponent<DialogueSystem>();
        }
        
        private void OnTriggerEnter(Collider other) 
        {
            dialogueSystem.StartDialogue(dataDialogue);
        }

        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    } 
}

