using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene(0);
    }
    public void OnButtonClick1()
    {
        SceneManager.LoadScene(1);

    }
    public void OnButtonClick2()
    {
        SceneManager.LoadScene(2);

    }
    public void OnButtonClick3()
    {
        SceneManager.LoadScene(3);

    }
}