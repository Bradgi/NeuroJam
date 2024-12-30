using UnityEngine;

public class MyDocuments : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameManager.Instance.documentsOpen && !GameManager.Instance.folderOpen)
        {
            GameManager.Instance.folderOpen = true;
            GameManager.Instance.documentsOpen = true;

            GameObject.FindGameObjectWithTag("Folder/Documents").transform.position = new Vector3(1.90999997f,2.29999995f,0);
        }
    }
}
