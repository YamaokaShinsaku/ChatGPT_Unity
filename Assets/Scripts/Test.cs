using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // APIキーを入力
        var openAIApiKey = "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"; 
        var chatGPTConnection = new ChatGPTConnection(openAIApiKey);
        // ChatGPTにする質問を入力
        // 好きな魚料理を1つ教えて など
        chatGPTConnection.RequestAsync("{{好きな魚料理を1つ教えて}}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
