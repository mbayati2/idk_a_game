using UnityEngine;

[System.Serializable]
public class Response
{
    [SerializeField] private string responseText;
    [SerializeField] private DialogueObject dialogueObject;
    private AudioClip talkSFX;
    private float pitch = 1f;
    private float textPerSeconds = 50f;

    public string ResponseText => responseText;

    public DialogueObject DialogueObject => dialogueObject;

    public AudioClip TalkSFXRe => dialogueObject.TalkSFX;

    public float Pitch => dialogueObject.Pitch;

    public float TextPerSecond => dialogueObject.TextPerSecond;
}
