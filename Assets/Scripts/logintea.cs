using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class logintea : MonoBehaviour
{
    public InputField inputusername;
    public InputField inputpassword;
    public Text textlLoginResult;




    IEnumerator ieLogin()
    {
        WWWForm dataform = new WWWForm();
        dataform.AddField("username", inputusername.text);
        dataform.AddField("password", inputpassword.text);
        string url = "http://localhost/StudentLogin/login.php";

        UnityWebRequest webRequest = UnityWebRequest.Post(url, dataform);
        webRequest.chunkedTransfer = false;

        yield return webRequest.SendWebRequest();


        Debug.Log(webRequest.downloadHandler.text);

        if (inputusername.text == "" || inputpassword.text == "")
        {

            textlLoginResult.text = "Please Enter Username and Password";

        }
        else
        {
            textlLoginResult.text = "Please Enter Username and Password";
            if (inputusername.text == inputpassword.text)
            {
                SceneManager.LoadScene(20);
            }
            else
            {
                textlLoginResult.text = "Username and Password is Incorrect";
            }
        }

    }

    public void Login()
    {
        StartCoroutine(ieLogin());
    }
}