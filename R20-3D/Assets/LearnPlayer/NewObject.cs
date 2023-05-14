using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "newObject", menuName = "Teddy/ScriptObject", order = 0)]
public class NewObject : ScriptableObject 
{
    public string objectName;
    public float atk;
    public UnityEvent atkATK;
    [SerializeField] private Sprite icon;
}
