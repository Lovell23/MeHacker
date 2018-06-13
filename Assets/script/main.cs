using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour {

    public GameObject info1;
    public GameObject lvl_1;
    public GameObject lvl_2;
    public GameObject folder;
    public GameObject app;
    public GameObject in_client;
    public GameObject in_client_error;
    public GameObject Bank;
    public GameObject OK;
    public GameObject OK_brute;
    public GameObject OK_wrong;
    public GameObject Close;
    public GameObject cmd_app;
    public GameObject accept_button;
    public GameObject logs;
    public GameObject panel;
    public GameObject bruteforce;
    public GameObject brute_cli;
    public GameObject shover;

    public Text wrong;

    public InputField logins;
    public InputField logins_brute;
    public InputField passwordbrut;
    public InputField password;
    public InputField cmd;
    public InputField cmd_2;
   
    public GameObject accept1;
    public GameObject accept2;
    public GameObject wrong_panel;

    public int cmd_window = 0;
    public int cmd_text = 0;
    public int VALUE;

    bool isStarted = false;

    public Showe showe;

    private void Awake()
    {
        showe.Show(new string[]{ "Привет, меня зовут Елена. Я буду твоим партнером. Перед тем, как мы сможем взломать сервера Sony и Microsoft, нам необходимо потренироватьься на более легки целях. Также, нам необходимо улучшить наш софт, так что, в любом случае нам нужны деньги", "Наша цель - In_Client. Унего примитивная защита, кроме того, я собрала информацию о его директоре. Ты можешь прочитать ее в файле, который наодится в папке на рабочем столе. Прочитай ее внимательно , так как нам придется поддбирать пароль. После этого открой cmd на рабочем столе"});
    }

    void Start() {
    }

    void Update()
    {
        
        login1();

        cmd1();

        if (isStarted) {
            StartCoroutine(password_rnd());
        } else {
            StopCoroutine(password_rnd());
        }
    }

    public void close1()
    {
        folder.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
       
    }
    public void close2()
    {
        lvl_1.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);

    }
    public void close3()
    {
        in_client.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);

    }
    public void close4()
    {
        cmd_text = 0;
        cmd.text = "";
        cmd_app.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);   
    }
    public void close5()
    {
        brute_cli.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
    }

    public void close6()
    {
        lvl_2.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
    }

    public void close7()
    {
        Bank.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
    }
    public void info()
    { 
            lvl_1.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
    }

    public void lvl2()
    {
        lvl_2.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
    }



    public void folders()
    {
        folder.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
    }
    public void app1()
    {
        in_client.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);

    }
    public void brute_client()
    {
        brute_cli.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
    }

    public void login()
    {
        if (logins.text == "Антон1984" && password.text=="Fire1965")
        {

            showe.Show("Неправильный пароль?!Да, это было бы слишком просто. ОК, я отправлю брутфорс на твой компьютер. Попробуешь взломать его аккаунт.");
            bruteforce.gameObject.SetActive(true);
            password.text = VALUE.ToString();
            password.text = string.Empty;

            print("lox");
            //wrong.text = "GJ";
            //ошибка если пароль или логин не верный
        }
        else
             if (logins.text == "Антон1984" && password.text == "54687")
        {
            panel.gameObject.SetActive(true);
            Bank.gameObject.SetActive(true);
            in_client.gameObject.SetActive(false);
        }


    }
    public void in_client_er()
    {
        in_client_error.gameObject.SetActive(false);
    }
    public void bank()
    {



    }

    public void login1()
    {
        if (logins_brute.text == "Антон1984" )
        {
            OK_brute.gameObject.SetActive(true);
        }
        else
        {
            OK_brute.gameObject.SetActive(false);
        }
    }



    public void OK_wr()
    {
        wrong_panel.gameObject.SetActive(false);
       panel.gameObject.SetActive(false);
    }

   


    public void cmd_open()
    {
       
            cmd_app.gameObject.SetActive(true);
            panel.gameObject.SetActive(true);
        if (cmd_window == 0)
        {
            showe.Show("ОК, теперь введи\"connect 192.168.13.37\" и нажми Enter. После этого тебе надо будет ввести пароль. Можешь проверить файл на рабочем столе, если забыл возмодные пароли. (Нам не нужно чистить логи сейчас, ибо они даже не знают, что это");

            cmd_window++;
        }
        if (cmd_window == 2)
        {
            showe.Show("Отлично, введи \"C:/documents/bank/logs.txt\", чтобы сохранить файл на рабочий стол.");
            cmd_window++;
        }
       
    }
    

    public void cmd1()
    {
        if (cmd_2.text == "connect 192.168.13.37" && Input.GetKey(KeyCode.Return) && cmd_text == 0 || cmd_2.text == "connect 192.168.13.37" && Input.GetKeyDown("enter") && cmd_text == 0 || cmd_2.text == "Connect 192.168.13.37" && Input.GetKeyDown("enter") && cmd_text == 0 || cmd_2.text == "Connect 192.168.13.37" && Input.GetKey(KeyCode.Return) && cmd_text == 0)
        {

            cmd.text += "Mirracle@ubantu: " + cmd_2.text + "\n";

            cmd.text += "Подключение произошло успешно\n"; 
        
          
            cmd.text += "Введите пароль:\n";
            cmd_text = 1;
            cmd_2.text = "";
        }
        
        if(cmd_2.text == "24011965"&&cmd_text==1 && Input.GetKey(KeyCode.Return))
        {
            cmd.text += "Mirracle@ubantu: " + cmd_2.text + "\n";
            cmd.text += "Пароль верен\n";
            cmd_text = 2;
            cmd_window++;
            cmd_2.text = "";
            showe.Show(new string[] { "Отличная работа! Мы вошли. Теперь мы можем украсть его логин и пароль от банковского счета. Если често, я уже его вламывала и знаю, где находится файл с логином и паролем, но на твоих следующих заданиях тебе придется искать файл самому. ","Теперь введи в cmd \"C:/documents/bank/logs.txt\" чтобы получить этот файл. Он будет автоматически скачан и размещен на твоем рабочем столе."});
        }

        if(cmd_2.text == "C:/documents/bank/logs.txt" && cmd_text==2&&  Input.GetKey(KeyCode.Return))
        {
            cmd.text += "Mirracle@ubantu: " + cmd_2.text + "\n";
            cmd.text += "Файл сохранен\n";
            cmd_2.text = "";
            cmd_text = 3;
            // сделать окно о появление файла
            showe.Show("Хммм... Странно, но у него почти такой же пароль. Ладно, попробуй его.");
            logs.gameObject.SetActive(true);
        }
    }
    
    public void brut_cl()
    {
        bruteforce.gameObject.SetActive(true);
        wrong_panel.gameObject.SetActive(false);
        panel.gameObject.SetActive(true);
    }
    public void cmd_win()
    {
        accept1.gameObject.SetActive(false);
        accept2.gameObject.SetActive(false);
    }
    public void password_brute()
    {
        isStarted = true;
        StartCoroutine(password_rnd());
    }

    IEnumerator password_rnd() {
        VALUE = Random.Range(0, 99999);
        passwordbrut.text = VALUE.ToString();
        yield return new WaitForSeconds(5.0f);
        VALUE = 54687;
        passwordbrut.text = VALUE.ToString();
        isStarted = false;
    }


    public void bank_next()
    {
        SceneManager.LoadScene("Bomj2");
    }
}
    