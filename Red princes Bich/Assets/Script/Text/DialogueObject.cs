using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]
public class DialogueObject : ScriptableObject
{
    [SerializeField] [TextArea] private string[] dialogue;
    [SerializeField] private Response[] responses;
    [SerializeField] private AudioClip talkSFX;
    [SerializeField] private float pitch = 1f;
    [SerializeField] private float textPerSecond = 50f;
    [SerializeField] private bool wobbing = false;
    [SerializeField] private float wobbing1 = 20f;
    [SerializeField] private float wobbing2 = 20f;


    public string[] Dialogue => dialogue;

    public bool HasResponses => Responses != null && Responses.Length > 0;

    public Response[] Responses => responses;

    public AudioClip TalkSFX => talkSFX;

    public float Pitch => pitch;

    public float TextPerSecond => textPerSecond;

    public bool Wobbing => wobbing;

    public float Wobbing1 => wobbing1;

    public float Wobbing2 => wobbing2;
}
