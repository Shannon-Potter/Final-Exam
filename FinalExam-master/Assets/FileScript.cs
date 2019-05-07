using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class FileScript : MonoBehaviour
{

    static string[] scoreData = new string[6];
    static string[] playerData = new string[6];
    string[] newLineDelimData;
    List<string> commaDelimData = new List<string>();
    public Text highScoreDisplay;
    public static bool updateFlag = false;


    string fileName = "Assets/scores.txt";
    // Use this for initialization
    void Start()
    {
        readHighScores();
        writeHighScores();
    }

    void readHighScores()
    {
        loadData();
        if (updateFlag)
        {
            updateHighScores();
            writeHighScores();
        }



        highScoreDisplay.text = "High Scores:\n" + playerData[0] + " " + scoreData[0] + "\n" +
            playerData[1] + " " + scoreData[1] + "\n" +
            playerData[2] + " " + scoreData[2] + "\n" +
            playerData[3] + " " + scoreData[3] + "\n" +
            playerData[4] + " " + scoreData[4];




    }
    void loadData()
    {
        StreamReader sr = new StreamReader(fileName);
        string rawData = sr.ReadToEnd();
        sr.Close();
        string[] newLineDelimData = rawData.Split('\n');

        foreach (string s in newLineDelimData)
        {
            commaDelimData.AddRange(s.Split(','));
            Debug.Log(s);
            //foreach (string s2 in commaDelimData)
            //Debug.Log(s2);
        }
        foreach (string s2 in commaDelimData)
            Debug.Log("s2: " + s2);

        //for (int i = 0; i < 10; i++)


        int c1 = 0;
        int c2 = 0;
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            if (i == 0 || i % 2 == 0)
            {
                playerData[c1] = commaDelimData[i];
                c1++;
            }
            else
            {
                scoreData[c2] = commaDelimData[i];
                c2++;
            }
        }
    }

    void updateHighScores()
    {

        scoreData[5] = ScoreKeeper.newScore.ToString();
        playerData[5] = MidScript.playerName;


        for (int i = 0; i < scoreData.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (int.Parse(scoreData[j - 1]) < int.Parse(scoreData[j]))
                {
                    string temp = scoreData[j - 1];
                    scoreData[j - 1] = scoreData[j];
                    scoreData[j] = temp;

                    temp = playerData[j - 1];
                    playerData[j - 1] = playerData[j];
                    playerData[j] = temp;
                }
            }
        }


    }

    void writeHighScores()
    {
        StreamWriter sw = new StreamWriter(fileName);
        sw.WriteLine(playerData[0] + "," + scoreData[0]);
        sw.WriteLine(playerData[1] + "," + scoreData[1]);
        sw.WriteLine(playerData[2] + "," + scoreData[2]);
        sw.WriteLine(playerData[3] + "," + scoreData[3]);
        sw.WriteLine(playerData[4] + "," + scoreData[4]);

        sw.Close();
    }
}
