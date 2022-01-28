
using WebSocketSharp;
using UnityEngine;
using System;
using System.Threading;

public class WSocket : MonoBehaviour
{
    WebSocket ws;

    public Animator controllerRobot;
    public string message;
    public int animationIndex;
    public GameObject Robot;


    void Start()
    {


        // controllerRobot = GetComponent<Animator>();
        //Robot = GetComponent<GameObject>();



        //Robot = GameObject.Find("Robot Kyle");


        ws = new WebSocket("ws://localhost:9500");

        ws.OnMessage += (sender, e) =>
        {

            message = e.Data;
        };

        ws.Connect();
    }


    void Update()
    {
        if (ws == null)
        {
            return;
        }



        if (message != "")
        {
            animationIndex = Int32.Parse(message);
        }

        switch (message)
        {
            case "0":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;
            case "1":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;
            case "2":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;
            case "3":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;
            case "4":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;
            case "5":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;
            case "6":
                controllerRobot.SetInteger("condicao", animationIndex);
                break;

        }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            ws.Send("0");
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            ws.Send("1");
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            ws.Send("2");
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            ws.Send("3");
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            ws.Send("4");
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            ws.Send("5");
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            ws.Send("6");
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            ws.Send("7");
        }


    }
}
