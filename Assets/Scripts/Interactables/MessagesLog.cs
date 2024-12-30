using TMPro;
using UnityEngine;

public class MessagesLog : MonoBehaviour
{
    [SerializeField] private GameObject errorLogUI;

    private void Start()
    {
        errorLogUI.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameManager.Instance.textMessagesOpen = true;
        errorLogUI.SetActive(true);
    }
}
