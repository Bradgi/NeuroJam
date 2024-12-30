using UnityEngine;

public class OutputFolder : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameManager.Instance.outputOpen)
        {
            GameManager.Instance.outputOpen = true;

            GameObject.FindGameObjectWithTag("Folder/Output").transform.position = new Vector3(1.90999997f,2.29999995f,0);

            GameManager.Instance.documentsOpen = false;

            GameObject.FindGameObjectWithTag("Folder/Documents").transform.position = new Vector3(-500, -500,0);
        }
    }
}
