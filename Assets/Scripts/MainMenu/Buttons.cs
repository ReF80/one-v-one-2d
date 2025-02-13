using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGameButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
