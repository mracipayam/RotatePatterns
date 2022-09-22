using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create EnemyData", fileName = "EnemyData", order = 0)]
public class EnemyData : ScriptableObject
{
    private float _maxSpeed = 10f;
    private float _attackRange = 40f;
    private float _attackDamage = 10f; 
}
