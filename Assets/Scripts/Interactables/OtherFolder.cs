using UnityEngine;

public class OtherFolder : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameManager.Instance.otherOpen)
        {
            GameManager.Instance.folderOpen = true;
            GameManager.Instance.otherOpen = true;

            GameObject.FindGameObjectWithTag("Folder/Other").transform.position = new Vector3(1.90999997f,2.29999995f,0);

            GameManager.Instance.documentsOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Documents").transform.position = new Vector3(-500, -500,0);
        }
    }
}
