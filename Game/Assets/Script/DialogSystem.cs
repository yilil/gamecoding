


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    [Header("UI组件")]
    public Text textLabel;
    public Image faceImage;

    [Header("文本组件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    bool textFileFinished;

    [Header("头像")]
    public Sprite face01, face02;  

    List<string> textlist = new List<string>();
    // Start is called before the first frame update
    void Awake()
    {
        GetTextFromFile(textFile);
        
    }
    private void OnEnable()
    {
        //textLabel.text = textlist[index];
        //index++;
        StartCoroutine(SetTextUI());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && index == textlist.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
            
        }
        if(Input.GetKeyDown(KeyCode.R) && textFileFinished)
        {
            //textLabel.text = textlist[index];
            //index++;
            StartCoroutine(SetTextUI());
        }
    }

    void GetTextFromFile(TextAsset file)
    {
        textlist.Clear();
        index = 0;

        var lineData = file.text.Split('\n');

        foreach(var line in lineData)
        {
            textlist.Add(line);
        }

    }

    IEnumerator SetTextUI()
    {
        textFileFinished = false;
        textLabel.text = "";

        switch (textlist[index])
        {
            case "A\r":
                faceImage.sprite = face01;
                index++;
                break;

            case "B\r":
                faceImage.sprite = face02;
                index++;
                break;
   
        }
        for(int i=0; i<textlist[index].Length; i++)
        {
            textLabel.text += textlist[index][i];
            yield return new WaitForSeconds(textSpeed);
        }
        textFileFinished = true; 
        index++;
        
    }
}
