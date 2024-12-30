using UnityEngine;

public class CloseOther : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.Instance.otherOpen)
        {
            GameManager.Instance.folderOpen = false;
            GameManager.Instance.otherOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Other").transform.position = new Vector3(-500, -500,0);
        }
    }
}
