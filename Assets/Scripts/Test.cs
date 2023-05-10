using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAA.OpenAI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // APIキーを入力
        var openAIApiKey = "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"; 
        var chatGPTConnection = new ChatGPTConnection(openAIApiKey);
        chatGPTConnection.RequestAsync("{{好きな魚料理を1つ教えて}}");
        //好きな魚料理を1つ教えて など
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
