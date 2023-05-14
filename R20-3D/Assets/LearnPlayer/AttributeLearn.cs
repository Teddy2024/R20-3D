using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AttributeLearn : MonoBehaviour
{
    [Header("標題")]
    [Range(0,100)]
    public int number;
    [Space(50)]
    [Tooltip("這是字串")]
    [Multiline(5)]
    public string text;
    [TextArea(1,10)]
    public string text2;
    [ContextMenuItem("點我測試ResetText",nameof(ResetText))]
    public string text3;


    private void ResetText()
    {
        text3 = "";
    }

    [ContextMenu("點我測試TestContextMenu")]
    private void TestContextMenu()
    {
        Debug.Log("TestContextMenu");
    }
}
