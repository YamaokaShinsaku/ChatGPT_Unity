using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // API�L�[�����
        var openAIApiKey = "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"; 
        var chatGPTConnection = new ChatGPTConnection(openAIApiKey);
        // ChatGPT�ɂ��鎿������
        // �D���ȋ�������1������ �Ȃ�
        chatGPTConnection.RequestAsync("{{�D���ȋ�������1������}}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
