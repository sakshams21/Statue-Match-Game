using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restar : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("Start",LoadSceneMode.Single);
    }
}
