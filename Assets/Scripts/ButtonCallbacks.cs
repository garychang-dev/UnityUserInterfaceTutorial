using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonCallbacks : MonoBehaviour
{
    public void PrintHelloWorld()
    {
        // Unused
        Debug.Log("Hello World!");
    }

    public void GoToGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
