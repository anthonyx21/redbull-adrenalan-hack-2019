using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BestHTTP.SocketIO;

public class SoundCon : MonoBehaviour
{
    void Start()
    {

        //manager = new SocketManager(new System.Uri("https://67c61e49.ngrok.io/socket.io/"));
        //manager.Socket.Emit("doneSpeaking");
        //manager.Socket.On("message", OnMessage);


    }
    // Update is called once per frame
    void OnMessage(Socket socket, Packet packet, params object[] args)
    {
        //Dictionary<string, object> boooo = (Dictionary<string, object>)args[0];
        //var action = (string)boooo["speech"];
        //print(action);
        //for (var i = 0; i < animators.Length; i++)
        //{
        //    animators[i].Play(action);

        //}

    }
