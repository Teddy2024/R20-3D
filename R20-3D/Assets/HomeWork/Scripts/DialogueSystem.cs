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
        private DialogueData dialogueOpening;
        [SerializeField, Header("對話案件")]
        private KeyCode dialogueKey = KeyCode.Space;

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

            //啟動協程
            StartCoroutine(FadeGroup());
            StartCoroutine(TyperEffect());
        }    
        #endregion
        
        private IEnumerator FadeGroup()
        {
            for(int i = 0; i < 10; i++)
            {
                groupDialogue.alpha += 0.1f;
                yield return new WaitForSeconds(0.04f);
            }
        }
        private IEnumerator TyperEffect()
        {
            //取得名子
            textName.text = dialogueOpening.dialogueName;

            //迴圈對話段
            for(int j = 0; j < dialogueOpening.dialogueContents.Length; j++)
            {
                textContent.text = "";
                goTriangle.SetActive(false);
                //此段文字為所取得的對話段
                string dialogue = dialogueOpening.dialogueContents[j];

                //將取得對話段的文字,放入此物件文字內容
                //將此段文字以協程方式輸出
                for(int i = 0; i < dialogue.Length; i++)
                {
                    textContent.text += dialogue[i];
                    yield return dialogueIntervalTime;
                }
               
                goTriangle.SetActive(true);

                //還沒按下按鍵就等待
                while (!Input.GetKeyDown(dialogueKey))
                {
                    yield return null;
                }
            }
            
        }
    }
}

