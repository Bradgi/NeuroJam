using UnityEngine;

public class CloseOutput : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.Instance.outputOpen)
        {
            GameManager.Instance.folderOpen = false;
            GameManager.Instance.outputOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Output").transform.position = new Vector3(-500, -500,0);
        }
    }
}
