using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class lab3ProblemA : MonoBehaviour
{
    public int numModules;
    public int numReadingMats;
    public int numQuizzes;
    public int numAssignments;
    public bool newCourse;
    public string nameCourse;

    // Start is called before the first frame update
    void Start()
    {
        challengeScore();

    }
    void challengeScore()
    {
        double score = 0;
        //Is it the first time the professor has taught the class
        if (newCourse) {
            score += 1;
        }

        //Reading Materials
        if (numReadingMats == 1)
        {
            score += 1;
        }
        else if (numReadingMats == 2)
        {
            score += 2;
        }
        else if (numReadingMats > 2)
        {
            score += 3;
        }

        //Modules
        if (numModules > 17)
        {
            score += 1.5;
        }
        else
        {
            score += .75;
        }

        //Number of Assignments
        if (numAssignments <= 90) {
            score += (numAssignments * .034);
        }
        else
        {
            score += 3;
        }

        //Number of Quizzes
        if (numQuizzes <= 8)
        {
            score += (numQuizzes / 5.33);
        }
        else
        {
            score += 1.5;
        }

        Debug.Log("The difficuly score of " + nameCourse + " is " + score);
    }
}
    // Update is called once per frame
