using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    private void Update()
    {
        // MainGame�� �ִ� GameOverCanvas gameobject�� ����
    }

    public void StartGame()
    {
        SceneManager.LoadScene("KYS_Test_Dummy"); // MainGame���μ��� �䱸
    }

    public void HandleGameOver()
    {
        // MainGame�� �ִ� GameOverCanvas gameobject�� SetActive(true)�������
    }

    public void Quit()
    {
        Application.Quit();
    }
}
