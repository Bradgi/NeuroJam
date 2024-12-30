using TMPro;
using UnityEngine;

public class ErrorLog : MonoBehaviour
{
    [SerializeField] private GameObject errorLogUI;

    private void Start()
    {
        errorLogUI.SetActive(false);
    }

    private void OnMouseDown()
    {
        GameManager.Instance.errorLogOpen = true;
        errorLogUI.SetActive(true);
    }
}
