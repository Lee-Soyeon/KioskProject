using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkVoice : MonoBehaviour
{
    public Text stt;
    public Text result;

    // Start is called before the first frame update
    void Start()
    {
        stt = GameObject.Find("Text_STT").GetComponent<Text>();
        result = GameObject.Find("Text_STT_Result").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void check(string text)
    {
        //string menu = "";

        //switch (text)
        //{
        //    case "\"빅맥\"":
        //        menu = "빅맥";
        //        result.text = menu + " 주문을 안내해 드리겠습니다";
        //        break;
        //}
    }
}