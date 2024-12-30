using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public void CloseTextMessages()
    {
        if (GameManager.Instance.textMessagesOpen)
        {
            GameManager.Instance.textMessagesOpen = false;
            GameObject.FindGameObjectWithTag("UI/Notepad").SetActive(false);
        }
    }

    public void CloseTerminal()
    {
        if (GameManager.Instance.terminalOpen)
        {
            GameManager.Instance.terminalOpen = false;
            GameObject.FindGameObjectWithTag("UI/Terminal").SetActive(false);
        }
    }

    public void CloseErrorLog()
    {
        if (GameManager.Instance.errorLogOpen)
        {
            GameManager.Instance.errorLogOpen = false;
            GameObject.FindGameObjectWithTag("UI/ErrorNotepad").SetActive(false);
        }
    }
}