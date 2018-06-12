using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showe : MonoBehaviour {

    public GameObject thsHandler;
    public Text textPanel;
    Queue<string> strings = new Queue<string>();
    private TW_MultiStrings_Regular tw;

    private void Start()
    {
        tw = textPanel.GetComponent<TW_MultiStrings_Regular>();
    }

    public void Show(string textH)
    {
        if (!this.gameObject.activeSelf) this.gameObject.SetActive(true);
        textPanel.text = textH;
        textPanel.gameObject.SetActive(true);
    }

    public void Show(string[] textH)
    {
        this.strings.Clear();

        foreach (string item in textH)
        {
            this.strings.Enqueue(item);
        }

        Show(this.strings.Dequeue());
    }

    public void Clear()
    {
        if (!textPanel.gameObject.activeSelf) textPanel.gameObject.SetActive(false);
        textPanel.text = string.Empty;

    }

    public void Close()
    {
        Clear();
        textPanel.gameObject.SetActive(false);
        print(this.strings.Count);
        if (this.strings.Count != 0) Show(this.strings.Dequeue());
        else this.gameObject.SetActive(false);
    }
}
