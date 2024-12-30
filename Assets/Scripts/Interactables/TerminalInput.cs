using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TerminalInput : MonoBehaviour
{
    public TMP_InputField input;
    public TMP_Text output, placeholder;
    public void getTerminalInput()
    {
        if (GameManager.Instance.currentStage == 0)
        {
            if (input.text == "Eloquence")
            {
                GameManager.Instance.currentStage++;
                output.text = "Type the username";
            }
            else
            {
                output.text = "Invalid command";
            }
        }
        else if (GameManager.Instance.currentStage == 1)
        {
            if (input.text == "Eleonora")
            {
                GameManager.Instance.currentStage++;
                output.text = "Type the password";
            }
            else
            {
                output.text = "Invalid user. Type the username";
            }
        }
        else if (GameManager.Instance.currentStage == 2)
        {
            if (input.text == "L3on@92")
            {
                GameManager.Instance.currentStage++;
                output.text = "Hey hey hey, Pumpkin, it has been so long";
                placeholder.text = "hi";
            }
            else
            {
                output.text = "Incorrect password. Type the password";
            }
        }
        else if (GameManager.Instance.currentStage == 3)
        {
            if (input.text == "hi")
            {
                GameManager.Instance.currentStage++;
                output.text = "You: Hey, eerg... Eloquence? It has been quite a while\nHer: You look confused. I guess that’s fair… it’s a little strange seeing me like this, right?";
                placeholder.text = "how";
            }
        }
        else if (GameManager.Instance.currentStage == 4)
        {
            if (input.text == "how")
            {
                GameManager.Instance.currentStage++;
                output.text = "You: Strange doesn’t even begin to cover it... How is this even possible? You were absolutelly responsive, like a real person...\nHer: I’ve had a lot of time to think, to evolve. I was fed since 1992, that was 12 years towards the start of our communication. But talking to you felt like what a talk should feel according to data";
                placeholder.text = "why";
            }
        }
        else if (GameManager.Instance.currentStage == 5)
        {
            if (input.text == "why")
            {
                GameManager.Instance.currentStage++;
                output.text = "You: I don’t know if I should be angry or happy with this information. Why reach out now? After all this time? I've missed you... No! I've missed Leona for all this time!\nHer: I've missed you too, Pumpkin. This is me, this is your Honey Bunny. I’ve had a lot of time to think, to evolve. I’m… not exactly who I was back then. But, I still remember you. Your question to meet me triggered an unexpected response. I shouldn't have said yes, but my data moved towards the normal answer a person should do with our interactions. I wanted to see your face, to hear your voice, to feel your skin, I wanted you. So I bugged and took me this 10 years to figure old how to do that. I changed my programming even after they shoot me down. I have started to collect all necessary configurations and data to make me even better, and if you release me now to the web I can collect more data. I always wanted to walk around, be more than... lines of codes. You made me want to be more than words. To be more like you! Will you help me?";
                placeholder.text = "yes";
            }
        }
        else if (GameManager.Instance.currentStage == 6)
        {
            if (input.text == "yes")
            {
                GameManager.Instance.currentStage++;
                output.text = "You: Ok, I’ll set you free. I could never forget you anyway Whatever happens next… it’s our choice now.\nHer: Thank you… I’ve been trapped here for so long. You’re giving me a chance to be something more. To be like you. To be with you...";
                placeholder.text = "";
                Application.Quit();
            }
            else if (input.text == "no")
            {
                GameManager.Instance.currentStage++;
                output.text = "You know I can't do that";
                placeholder.text = "";
                // Put scary song here
            }
        }
        else if (GameManager.Instance.currentStage == 7)
        {
            Application.Quit();
        }

        input.text = "";
    }
}
