using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public string resetTag = "ButtomWall";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(resetTag))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
