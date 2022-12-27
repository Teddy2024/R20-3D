using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Teddy
{
    public class DialogueSystem : MonoBehaviour
    {
        #region 資料區域
        [SerializeField, Header("對話間格"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;

        [SerializeField, Header("開頭對話")]
        private DialogueData  dialogueOpening;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);
        //prop(屬性欄)看不懂,LAMBDA=>也看不懂
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;
        #endregion

        #region 事件
        private void Awake() 
        {
            groupDialogue = GameObject.Find("TalkCanvas").GetComponent<CanvasGroup>();
            textName = GameObject.Find("Talker").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("TalkSomething").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("TalkFinishIcon");
            goTriangle.SetActive(false);
        }    
        #endregion
        
    }
}

