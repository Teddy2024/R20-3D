using UnityEngine;
using UnityEngine.Events;
using System;

public class PlayerDataApply : MonoBehaviour
{
    public PlayerClass playerClass;
    
    [SerializeField] private string _name;
    [SerializeField] private float _attack;
    [SerializeField] private float _health;

    public bool _canJump;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private float _jumpSpeed;

    [SerializeField] private float _magicPower;
    [SerializeField] private float _magicCD;

    [SerializeField] private float _swordPower;
    [SerializeField] private float _shieldPower;

    [SerializeField] private UnityEvent deathEvent;
}
[Serializable] public enum PlayerClass{ Warrior, Magican }
