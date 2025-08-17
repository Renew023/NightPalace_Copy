using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "EnemyStat", menuName ="EnemyStatData/EnemyStats")]
public class EnemyStatData : ScriptableObject
{
    public float damage; // 데미지? 감염도?
    public float moveSpeed; // 좀비 종류에 따라 속도 다르게
    public float detectRange; // 감지 범위
    public float attackRange; // 공격 범위
    public float attackCoolTime; // 공격 쿨타임
    public float danceRange; // 댄스 범위
    public float soundSensedRange; //소리 감지 범위
}
