using UnityEngine;

namespace Teddy
{
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";
        
        private void OnTriggerEnter(Collider other) 
        {
            
        }
    } 
}

