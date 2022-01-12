using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButton : MonoBehaviour
{
    public void Leveel01()
    {
        SceneManager.LoadScene("Level01");
    }
}
