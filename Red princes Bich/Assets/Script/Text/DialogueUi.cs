using System.Collections;
using UnityEngine;
using TMPro;

public class DialogueUi : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text text_label;
    [SerializeField] private DialogueObject dialogue;

    private ResponseHandler responseHandler;
    private TypeWriter typeWriterEffect;
    [HideInInspector] public AudioClip talkSFX;
    [HideInInspector] public float pitch = 1f;

    [HideInInspector] public float textPerSecond = 50f;

    [HideInInspector] public bool wobbing = false;
    [HideInInspector] public float wobbing1 = 10f;
    [HideInInspector] public float wobbing2 = 10f;

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriter>();
        responseHandler = GetComponent<ResponseHandler>();

        talkSFX = dialogue.TalkSFX;
        pitch = dialogue.Pitch;
        textPerSecond = dialogue.TextPerSecond;
        wobbing = dialogue.Wobbing;
        wobbing1 = dialogue.Wobbing1;
        wobbing2 = dialogue.Wobbing2;

        ShowDialogue(dialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        talkSFX = dialogueObject.TalkSFX;
        pitch = dialogueObject.Pitch;
        textPerSecond = dialogueObject.TextPerSecond;
        wobbing = dialogueObject.Wobbing;
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        for (int i = 0; i < dialogueObject.Dialogue.Length; i++)
        {
            string dialogue = dialogueObject.Dialogue[i];
            typeWriterEffect.audioClip = talkSFX;
            typeWriterEffect.pitch = pitch;
            typeWriterEffect.textPerSecond = textPerSecond;
            yield return typeWriterEffect.Run(dialogue, text_label);
            

            if(i == dialogueObject.Dialogue.Length - 1 && dialogueObject.HasResponses) break;

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));
        }

        if (dialogueObject.HasResponses)
        {
            responseHandler.ShowResponses(dialogueObject.Responses);
        }
        else
        {
            CloseDialogueBox();
        }
    }

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        text_label.text = string.Empty;
    }

    #region
    Mesh mesh;

    Vector3[] vertices;

    // Update is called once per frame
    void Update()
    {
        if (wobbing == true)
        {
            text_label.ForceMeshUpdate();
            mesh = text_label.mesh;
            vertices = mesh.vertices;

            for (int i = 0; i < text_label.textInfo.characterCount; i++)
            {
                TMP_CharacterInfo c = text_label.textInfo.characterInfo[i];

                int index = c.vertexIndex;

                Vector3 offset = Wobble(Time.time + i);
                vertices[index] += offset;
                vertices[index + 1] += offset;
                vertices[index + 2] += offset;
                vertices[index + 3] += offset;
            }

            mesh.vertices = vertices;
            text_label.canvasRenderer.SetMesh(mesh);
        }
    }

    Vector2 Wobble(float time)
    {
        return new Vector2(Mathf.Sin(time * wobbing1), Mathf.Cos(time * wobbing2));
    }
    #endregion
}
