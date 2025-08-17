using System;
using UnityEngine;
using Cinemachine;

[Serializable]
public class GroundStateData 
{
    [field: SerializeField] public float WalkSpeed { get; private set; }
    [field: SerializeField] public float SprintSpeed {  get; private set; }
    [field: SerializeField] public float SprintStaminaIncrease {  get; private set; }
    [field: SerializeField] public float SprintStaminaDecrease {  get; private set; }
    [field: SerializeField] public float CrouchSpeed {  get; private set; }
    [field: SerializeField] public float CrouchDuration { get; private set; }
}

[Serializable]
public class CamShakeData
{
    [field: SerializeField] public NoiseSettings Noise { get; private set; }

    [field: Header("Idle")]    //기본 상태의 흔들림 폭과 주기
    [field: SerializeField] public float AmplitudeOnIdle { get; private set; } = 0.2f;
    [field: SerializeField] public float FrequencyOnIdle { get; private set; } = 0.005f;

    [field: Header("Walk")]    //걷는 상태의 흔들림 폭과 주기
    [field: SerializeField] public float AmplitudeOnWalk { get; private set; } = 0.2f;
    [field: SerializeField] public float FrequencyOnWalk { get; private set; } = 0.02f;

    [field: Header("Run")]     //달리는 상태의 흔들림 폭과 주기
    [field: SerializeField] public float AmplitudeOnSprint { get; private set; } = 0.3f;
    [field: SerializeField] public float FrequencyOnSprint { get; private set; } = 0.04f;

    [field: Header("Crouch")]     // 앉은 상태의 흔들림 폭과 주기
    [field: SerializeField] public float AmplitudeOnCrouch { get; private set; } = 0.1f;
    [field: SerializeField] public float FrequencyOnCrouch { get; private set; } = 0.001f;

    [field: Header("Jump")]     // 점프 상태의 흔들림 폭과 주기
    [field: SerializeField] public float AmplitudeOnJump { get; private set; } = 0.1f;
    [field: SerializeField] public float FrequencyOnJump { get; private set; } = 0.01f;
}

[Serializable]
public class AirStateData
{
    [field: SerializeField] public float JumpForce { get; private set; }
    [field: SerializeField] public float JumpStaminaDecrease { get; private set; }
}

[CreateAssetMenu(fileName = "new StateData", menuName ="StateData/PlayerStateData")]
public class StateData : ScriptableObject
{
    [field:SerializeField] public GroundStateData Ground { get; private set; }
    [field: SerializeField] public CamShakeData GroundCamShake { get; private set; }
    [field: SerializeField] public AirStateData Air { get; private set; }
}
