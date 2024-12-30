using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool folderOpen = false;
    public bool documentsOpen = false;
    public bool picturesOpen = false;
    public bool outputOpen = false;
    public bool otherOpen = false;
    public bool textMessagesOpen = false;
    public bool errorLogOpen = false;
    public bool imageViewerOpen = false;
    public bool terminalOpen = false;
    public string currentlyOpenImage = "";

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        Application.targetFrameRate = 30;
        QualitySettings.vSyncCount = 0;
    }
}
