using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public static MouseCursor Instance {get; private set;}

    [SerializeField] private Texture2D cursorTextureDefault;
    [SerializeField] private Texture2D cursorTextureHand;
    [SerializeField] private Texture2D cursorTextureNone;
    [SerializeField] private Vector2 clickPosition = Vector2.zero;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Cursor.SetCursor(cursorTextureNone, clickPosition, CursorMode.Auto);
    }

    public void SetToMode(MouseCursorMode cursorMode)
    {
        switch (cursorMode)
        {
            case MouseCursorMode.Default:
                Cursor.SetCursor(cursorTextureDefault, clickPosition, CursorMode.Auto);
                break;
            case MouseCursorMode.Hand:
                Cursor.SetCursor(cursorTextureHand, clickPosition, CursorMode.Auto);
                break;
            case MouseCursorMode.None:
                Cursor.SetCursor(cursorTextureNone, clickPosition, CursorMode.Auto);
                break;
            default:
                Cursor.SetCursor(cursorTextureNone, clickPosition, CursorMode.Auto);
                break;
        }
    }
}

public enum MouseCursorMode
{
    Default,
    Hand,
    None
}