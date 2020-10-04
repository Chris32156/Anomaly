using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Game : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] int startingTime;
    [SerializeField] int TimeIncrease;
    [SerializeField] float timerSpeed = 1;
    int Answer;
    int Anomaly;
    float CurrentTime;
    SceneManagement scene;
    AudioManager audio;
    bool a = false;
    // Start is called before the first frame update
    void Start()
    {
        scene = FindObjectOfType<SceneManagement>();
        audio = FindObjectOfType<AudioManager>();

        CurrentTime = startingTime;
        timerText.SetText(CurrentTime.ToString("0"));

        var people = FindObjectsOfType<Person>();
        Answer = Random.Range(1, 6);
        Anomaly = Random.Range(0, 5);

        Debug.Log(Anomaly);
        int x = Random.Range(0, 5);
        if (Answer == 0)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetHeads(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetHeads(indexArray[j]);
            }
        }

        if (Answer == 1)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyes(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyes(indexArray[j]);
            }
        }

        if (Answer == 2)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyebrows(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyebrows(indexArray[j]);
            }
        }

        if (Answer == 3)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetMouth(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetMouth(indexArray[j]);
            }
        }

        if (Answer == 4)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetShirt(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetShirt(indexArray[j]);
            }
        }

        if (Answer == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetHair(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetHair(indexArray[j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime * timerSpeed;
        timerText.SetText(CurrentTime.ToString("0"));
        if (CurrentTime < 0 && !a)
        {
            a = true;
            //Game Over
            scene.GameOver();
            audio.GameOverSound();
        }
    }

    int[] RandomIndex()
    {
        int[] indexs;
        indexs = new int[5];

        for (int i = 0; i < 5; i++)
        {
            indexs[i] = Random.Range(0, 5);
        }

        /* //Check Num Of Repeats
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < 5; i++)
        {
            if (dict[i] > 0)
            {
                dict[i]++;
            }
            else
            {
                dict[i] = 1;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (dict[i] > 3)
            {
                RandomIndex();
            }
        } */
        return indexs;
    }

    public void CheckAnswer(int buttonPressed)
    {
        if (buttonPressed == Anomaly)
        {
            //Correct
            audio.CorrectSound();
            CurrentTime += TimeIncrease;
        }
        else
        {
            //Wrong
            audio.WrongSound();
            CurrentTime -= TimeIncrease;
        }
        resetSprites();
        timerText.SetText(CurrentTime.ToString("0"));
    }

    void resetSprites()
    {
        var people = FindObjectsOfType<Person>();
        Answer = Random.Range(1, 6);
        Anomaly = Random.Range(0, 5);

        Debug.Log(Anomaly);
        int x = Random.Range(0, 5);
        if (Answer == 0)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetHeads(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetHeads(indexArray[j]);
            }
        }

        if (Answer == 1)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyes(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyes(indexArray[j]);
            }
        }

        if (Answer == 2)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyebrows(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetEyebrows(indexArray[j]);
            }
        }

        if (Answer == 3)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetMouth(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetMouth(indexArray[j]);
            }
        }

        if (Answer == 4)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetShirt(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetShirt(indexArray[j]);
            }
        }

        if (Answer == 5)
        {
            for (int j = 0; j < 5; j++)
            {
                people[j].SetHair(x, true, Anomaly);
            }
        }
        else
        {
            int[] indexArray = RandomIndex();

            for (int j = 0; j < 5; j++)
            {
                people[j].SetHair(indexArray[j]);
            }
        }
    }
}
