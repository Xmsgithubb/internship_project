
using UnityEngine;
using UnityEngine.SceneManagement;

public class controls : MonoBehaviour
{
public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
