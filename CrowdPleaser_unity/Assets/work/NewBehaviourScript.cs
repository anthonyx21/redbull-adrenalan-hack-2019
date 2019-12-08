using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using BestHTTP.SocketIO;



public class NewBehaviourScript : MonoBehaviour
{
    //SocketManager manager;
    private float nextActionTime = 0.0f;
    public float period = 10.0f;

    private string[,] emotions = { { "clapping", "cheering", "hiphop" }, {"happy","happy2","happy1" },{ "sad", "sad2", "idle" }, { "crying", "angry", "laughing" } };
    private string[] choices = { "clapping", "cheering", "hiphop" ,"happy","happy2","happy1" , "sad", "sad2", "idle" ,  "crying", "angry", "laughing"}; //"backflip"
    private string[] names = { "joe", "piggy", "rando", "nuasdf", "nexned", "blue", "albert","numo","rob","rin","aki","okey","m0ngo","raz0r","r3dd0","supp3r"}; //"backflip"
    public Animator[] animators;
    public TextMeshPro[] textMeshes;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        //manager = new SocketManager(new System.Uri("https://67c61e49.ngrok.io/socket.io/"));
        //manager.Socket.Emit("doneSpeaking");
        //manager.Socket.On("message", OnMessage);

        for (var i = 0; i < textMeshes.Length; i++)
        {
            var num = Random.Range(1, names.Length);
            textMeshes[i].SetText(names[i] + Random.Range(1,255));
        }

    }

    //void OnMessage(Socket socket, Packet packet, params object[] args)
    //{
    //    Dictionary<string, object> boooo = (Dictionary<string, object>)args[0];
    //    var action = (string)boooo["speech"];
    //    print(action);
    //    for (var i = 0; i < animators.Length; i++)
    //    {
    //        animators[i].Play(action);

    //    }

    //}
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;

            //if (Random.Range(0, 2) == 1)
            //{
            //    var num = Random.Range(0, 4);
            //    var num2 = Random.Range(0, 3);
            //    for (var i = 0; i < animators.Length; i++)
            //    {
            //        //print("x" + num + " " + num2);
            //        animators[i].Play(emotions[num, num2]);

            //    }
            //}
            //else
            {
                for (var i = 0; i < animators.Length; i++)
                {
                    //var num = Random.Range(1, choices.Length);
                    //animators[i].Play(choices[num]);
                    var num = Random.Range(0, 4);
                    var num2 = Random.Range(0, 3);
                    //print("x" + num + " " + num2);
                    animators[i].Play(emotions[num, num2]);

                }
            }
            
            // execute block of code here
        }
        //print("space key was pressed");
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (var i = 0; i < animators.Length; i++)
            {
                //var num = Random.Range(1, choices.Length);
                //animators[i].Play(choices[num]);
                var num = Random.Range(0, 4);
                var num2 = Random.Range(0, 3);
                print("x" + num + " " + num2);
                animators[i].Play(emotions[num,num2]);

            }
            //anim.Play("clapping");
            //print("clap");
        }
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    anim.Play("chicken");
        //    print("chick");
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    anim.Play("cheering");
        //    print("cheer");
        //}
    }
}
