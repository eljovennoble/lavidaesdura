using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  
    void Start()
    {
        Application.targetFrameRate =60;
        GameObject gameManager = GameObject.Find("codigoglobal");
        DontDestroyOnLoad(gameManager);
        SceneManager.LoadScene("escena00 menu");
    }

      

}
