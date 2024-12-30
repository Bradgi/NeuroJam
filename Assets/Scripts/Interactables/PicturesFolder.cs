using UnityEngine;

public class PicturesFolder : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameManager.Instance.picturesOpen)
        {
            GameManager.Instance.folderOpen = true;
            GameManager.Instance.picturesOpen = true;

            GameObject.FindGameObjectWithTag("Folder/Picture").transform.position = new Vector3(1.90999997f,2.29999995f,0);

            GameManager.Instance.documentsOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Documents").transform.position = new Vector3(-500, -500,0);
        }
    }
}
