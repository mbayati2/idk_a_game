using UnityEngine;

public class CreatingChar : MonoBehaviour
{
    [AddComponentMenu("")]


    [Header(" all Listed effect ")]
    [Header(" <bounce> <dangle> <fade> <pedn> ")]
    [Header(" <rainb> <rot> <shake> <incr> ")]
    [Header(" <slide> <swing> <wave> <wiggle> ")]
    [Header(" <waitfor=1> <speed=1> <waitinput> ")]

    [Header(" at the start of the game ")]
    [Space]
    [TextArea(5, 100), SerializeField]
    string textToShow1 = " ";

    [Header(" After name ")]
    [Space]
    [TextArea(5, 100), SerializeField]
    string textToShow2 = " ";

    [Header(" After Stat ")]
    [Space]
    [TextArea(5, 100), SerializeField]
    string textToShow3 = " ";

    [Header(" Befor Intro ")]
    [Space]
    [TextArea(5, 150), SerializeField]
    string textToShow4 = " ";

    private void Start()
    {
        ShowText();
    }

    public void ShowText()
    {

    }

}
