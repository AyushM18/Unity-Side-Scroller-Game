using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishPoint : MonoBehaviour
{
    public void  OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UnlockedNewLevel();
            SceneController.instance.NextLevel();
        }
    }

    void UnlockedNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1)+ 1);
            PlayerPrefs.Save();
        }
    }
}
