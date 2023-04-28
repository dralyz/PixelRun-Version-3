using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackScript : MonoBehaviour
{
    public void LoadScene(string StartScreen)
    {
        SceneManager.LoadScene(StartScreen);
    }
}