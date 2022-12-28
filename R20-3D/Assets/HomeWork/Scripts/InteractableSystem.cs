using UnityEngine;

namespace Teddy
{
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

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
    } 
}

