using TMPro;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class ResponseHandler : MonoBehaviour
{
    [SerializeField] private RectTransform responseBox;
    [SerializeField] private RectTransform responseButtonTemplate;
    [SerializeField] private RectTransform responseConatainer;

    private DialogueUi dialogueUi;

    List<GameObject> tempRespondButtons = new List<GameObject>();

    private void Start()
    {
        dialogueUi = GetComponent<DialogueUi>();
    }

    public void ShowResponses(Response[] responses)
    {
        float responseBoxHight = 0;

        foreach (Response response in responses)
        {
            GameObject responseButton = Instantiate(responseButtonTemplate.gameObject, responseConatainer);
            responseButton.gameObject.SetActive(true);
            responseButton.GetComponent<TMP_Text>().text = response.ResponseText;
            responseButton.GetComponent<Button>().onClick.AddListener(() => OnPickedResponse(response));

            tempRespondButtons.Add(responseButton);

            responseBoxHight += responseButtonTemplate.sizeDelta.y;
        }

        responseBox.sizeDelta = new Vector2(responseBox.sizeDelta.x, responseBoxHight);
        responseBox.gameObject.SetActive(true);
    }

    private void OnPickedResponse(Response response)
    {
        responseBox.gameObject.SetActive(false);

        foreach (GameObject button in tempRespondButtons)
        {
            Destroy(button);
        }
        tempRespondButtons.Clear();

        dialogueUi.ShowDialogue(response.DialogueObject);
        dialogueUi.talkSFX = response.TalkSFXRe;
        dialogueUi.pitch = response.Pitch;
        dialogueUi.textPerSecond = response.TextPerSecond;
        dialogueUi.wobbing = response.DialogueObject.Wobbing;
        dialogueUi.wobbing1 = response.DialogueObject.Wobbing1;
        dialogueUi.wobbing2 = response.DialogueObject.Wobbing2;
    }
}
