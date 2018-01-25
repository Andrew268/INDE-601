using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    public string[] score;

	// Use this for initialization
	IEnumerator Start () {
        WWW ScoreData = new WWW("http://localhost/ZombieDatabase/ScoreData.php");
        yield return ScoreData;
        string ScoreDataString = ScoreData.text;
        print(ScoreDataString);
        score = ScoreDataString.Split(';');
        print(GetDataValue(score[0], "Score:"));
		
	}

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index)+index.Length);
        if(value.Contains("|")) value = value.Remove(value.IndexOf("|"));
        return value;
    }
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
