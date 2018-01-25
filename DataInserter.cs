using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInserter : MonoBehaviour {

    public string inputUserName;
    public string inputScore;

    string createUserURL = "http://localhost/ZombieDatabase/ScoreData.php";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) CreateUser(inputUserName, inputScore);
	}

    public void CreateUser(string Name, string Score)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", Name);
        form.AddField("scorePost", Score);

        WWW www = new WWW(createUserURL, form);

    }
}
