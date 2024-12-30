using UnityEngine;

public class OpenTerminal : MonoBehaviour
{
    [SerializeField] private GameObject terminalUI;

    private void Start()
    {
        terminalUI.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameManager.Instance.terminalOpen = true;
        terminalUI.SetActive(true);
    }
}
