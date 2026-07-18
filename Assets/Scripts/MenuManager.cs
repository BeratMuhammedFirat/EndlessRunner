using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR  //Eğer kod Unity Editor içinde çalışıyorsa, aşağıdaki satırları derle.
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}