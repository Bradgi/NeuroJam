using UnityEngine;

public class CloseDocuments : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.Instance.documentsOpen)
        {
            GameManager.Instance.folderOpen = false;
            GameManager.Instance.documentsOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Documents").transform.position = new Vector3(-500, -500,0);
        }
    }
}
