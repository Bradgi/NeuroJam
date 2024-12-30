using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TerminalInput : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text output;
    public void getTerminalInput()
    {
        if (input.text == "test")
        {
            output.text = "good";
        }
        else
        {
            output.text = "bad";
        }

        input.text = "";
    }
}
