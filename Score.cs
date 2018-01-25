using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public InputField mainInputField;
    InputField iField;
    string myName;
    public float myTimer = 10;
    public Text timerText;
    public Text scoreText;
    public int score;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        myTimer -= Time.deltaTime;
        timerText.text = myTimer.ToString("f0");
        print(myTimer);

        scoreText.text = "Score: " + score;

        if (Input.GetMouseButtonDown(0) && myTimer > 0)
        {
            score++;
        }
    }

    private void OnGUI()
    {
        if (myTimer > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time remaining: " + myTimer);
            //mainInputField.text = "Enter Text Here...";
            mainInputField.ActivateInputField();

        }
        else
        {
            GUI.Label(new Rect(100, 100, 100, 100), "Time's up!");
        }

    }




}