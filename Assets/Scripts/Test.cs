using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Example;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Message message = new Message();
        message.Message_ = "  123123 ";

        byte[] data = message.ToByteArray();
        Message msg1 = Message.Descriptor.Parser.ParseFrom(data) as Message;
        var str = JsonFormatter.ToDiagnosticString(msg1);
        Message msg2 = Message.Descriptor.Parser.ParseJson(str) as Message;
        Debug.LogFormat("message{0},msg1(byte[] to){1},msg2(jsonStr to){2}",message.Message_,msg1.Message_,msg2.Message_);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
