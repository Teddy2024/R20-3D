using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerDataApply)), CanEditMultipleObjects]
public class PlayerDataApplyEditor : Editor
{
    #region 序列化變數
    SerializedProperty playerClass;
    
    SerializedProperty _name;
    SerializedProperty _attack;
    SerializedProperty _health;

    SerializedProperty _canJump;
    SerializedProperty _jumpHeight;
    SerializedProperty _jumpSpeed;

    SerializedProperty _magicPower;
    SerializedProperty _magicCD;

    SerializedProperty _swordPower;
    SerializedProperty _shieldPower;

    SerializedProperty _deathEvent;
    #endregion

    bool _playerGroup, _playerJumpGroup, _deathGroup, _magicGroup, warriorGroup;

    private void OnEnable() 
    {
        playerClass = serializedObject.FindProperty("playerClass");
        _name = serializedObject.FindProperty("_name");
        _attack = serializedObject.FindProperty("_attack");
        _health = serializedObject.FindProperty("_health");
        _canJump = serializedObject.FindProperty("_canJump");
        _jumpHeight = serializedObject.FindProperty("_jumpHeight");
        _jumpSpeed = serializedObject.FindProperty("_jumpSpeed");
        _magicPower = serializedObject.FindProperty("_magicPower");
        _magicCD = serializedObject.FindProperty("_magicCD");
        _swordPower = serializedObject.FindProperty("_swordPower");
        _shieldPower = serializedObject.FindProperty("_shieldPower");
        _deathEvent = serializedObject.FindProperty("deathEvent");
    }

    public override void OnInspectorGUI()
    {
        PlayerDataApply playerDataApply = (PlayerDataApply)target;

        serializedObject.Update();

            EditorGUILayout.PropertyField(playerClass);

            EditorGUILayout.Space(10);
            _playerGroup = EditorGUILayout.BeginFoldoutHeaderGroup(_playerGroup, "Player Group");
            if(_playerGroup)
            {
                EditorGUILayout.PropertyField(_name);
                GUILayout.BeginHorizontal();
                EditorGUILayout.PropertyField(_attack);
                EditorGUILayout.PropertyField(_health);
                GUILayout.EndHorizontal();
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            _playerJumpGroup = EditorGUILayout.BeginFoldoutHeaderGroup(_playerJumpGroup, "Jump Group");
            if(_playerJumpGroup)
            {
                EditorGUILayout.PropertyField(_canJump);
                if(playerDataApply._canJump)
                {
                    EditorGUILayout.PropertyField(_jumpHeight);
                    EditorGUILayout.PropertyField(_jumpSpeed);
                }
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            _deathGroup = EditorGUILayout.BeginFoldoutHeaderGroup(_deathGroup, "Death Group");
            if(_deathGroup)
            {
                EditorGUILayout.PropertyField(_deathEvent);
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            EditorGUILayout.Space(10);
            GUILayout.Label("職業資料");
            switch(playerDataApply.playerClass)
            {
                case PlayerClass.Magican:
                _magicGroup = EditorGUILayout.BeginFoldoutHeaderGroup(_magicGroup, "Magican Group");
                if(_magicGroup)
                {
                    EditorGUILayout.PropertyField(_magicPower);
                    EditorGUILayout.PropertyField(_magicCD);
                }
                EditorGUILayout.EndFoldoutHeaderGroup();
                break;
                case PlayerClass.Warrior:
                warriorGroup = EditorGUILayout.BeginFoldoutHeaderGroup(warriorGroup, "Warrior Group");
                if(warriorGroup)
                {
                    EditorGUILayout.PropertyField(_swordPower);
                    EditorGUILayout.PropertyField(_shieldPower);
                }
                EditorGUILayout.EndFoldoutHeaderGroup();
                break;
            }             
        serializedObject.ApplyModifiedProperties();
    }
}
