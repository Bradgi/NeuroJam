using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeCursor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private MouseCursorMode cursorMode;

    public void OnPointerEnter(PointerEventData eventData)
    {
        MouseCursor.Instance.SetToMode(cursorMode);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MouseCursor.Instance.SetToMode(MouseCursorMode.None);
    }
}
