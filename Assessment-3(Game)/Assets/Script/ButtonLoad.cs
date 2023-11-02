using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonLoad : MonoBehaviour
{
    public string pacStudent;
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene(pacStudent);
    }
}
