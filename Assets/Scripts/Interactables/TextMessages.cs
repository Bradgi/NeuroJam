using TMPro;
using UnityEngine;

public class TextMessages : MonoBehaviour
{
    [SerializeField] private GameObject textLogUI;

    private void Start()
    {
        textLogUI.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameManager.Instance.textMessagesOpen = true;
        textLogUI.SetActive(true);
    }
}
