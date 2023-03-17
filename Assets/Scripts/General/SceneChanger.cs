using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    void Start()
    {
        StartCoroutine(WaitForVideo());
    }

    IEnumerator WaitForVideo()
    {
        yield return new WaitForSeconds((float)videoPlayer.clip.length);

        SceneManager.LoadScene("LevelOne");
    }
}