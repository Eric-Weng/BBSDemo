using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(Input.GetKey(KeyCode.N))
        {
            int thisLevel = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(thisLevel + 1);
        }
    }
}
