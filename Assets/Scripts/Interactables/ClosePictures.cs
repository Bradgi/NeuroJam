using UnityEngine;

public class ClosePictures : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.Instance.picturesOpen)
        {
            GameManager.Instance.folderOpen = false;
            GameManager.Instance.picturesOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Picture").transform.position = new Vector3(-500, -500,0);
        }
    }
}
