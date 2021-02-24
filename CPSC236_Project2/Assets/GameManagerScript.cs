using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManagerScript : MonoBehaviour
{
    // Load the file of student names
    // On button click in UI, randomly pick a student name
    // Assign to text object in GUI the chosen student name

    // default file name
    public string fileName = "default.txt";
    public Text displayName;

    private string[] studentNames;

    // populate string array studentNames with student names from text file
    private void LoadStudentNames()
    {
        this.studentNames = File.ReadAllLines(fileName); // 'this' ensures that we are referring to the studentNames var in this class
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        ButtonClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, this.studentNames.Length);
        string name = this.studentNames[i];
        displayName.text = name;
    }
}
