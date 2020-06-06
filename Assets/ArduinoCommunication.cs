using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TechTweaking.Bluetooth;
using UnityEngine.UI;

public class ArduinoCommunication : MonoBehaviour {

    private BluetoothDevice device;
    public Text dataToSend;

    public void send()
    {
        dataToSend.GetComponent<Text>().text = "working";

        if (device != null && !string.IsNullOrEmpty(dataToSend.text))
        {
            device.send(System.Text.Encoding.ASCII.GetBytes(dataToSend.text + (char)10));//10 is our seperator Byte (sepration between packets)
        }
    }
}
