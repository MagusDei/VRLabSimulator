using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    public Text clickText;
    public Text overText;
    public Slider ragemeter;
    public Button but1;

    void Start()
    {
        clickText.text = "";
        overText.text = "";
        but1.gameObject.SetActive(false);

    }

    void OnMouseDown()
    {
        but1.gameObject.SetActive(true);
        clickText.text = "Don't do it!";
        ragemeter.value = ragemeter.value + 1;
        gameOver();
    }

    void gameOver()
    {
        if (ragemeter.value >= 10)
        {
            overText.text = "Game over!";
        }

    }
  
}
