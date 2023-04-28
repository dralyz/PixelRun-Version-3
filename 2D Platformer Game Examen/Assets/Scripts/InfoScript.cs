using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoScript : MonoBehaviour
{
    public void LoadScene(string InfoScreen)
    {
        SceneManager.LoadScene(InfoScreen);
    }
}