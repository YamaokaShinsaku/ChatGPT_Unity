using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAA.OpenAI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // API�L�[�����
        var openAIApiKey = "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"; 
        var chatGPTConnection = new ChatGPTConnection(openAIApiKey);
        chatGPTConnection.RequestAsync("{{�D���ȋ�������1������}}");
        //�D���ȋ�������1������ �Ȃ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
