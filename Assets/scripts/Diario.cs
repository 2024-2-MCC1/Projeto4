using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Diario : MonoBehaviour
{
    public Image Tela;
    public GameObject Text;
    public GameObject Diario_text;
    public GameObject Bottons;
    public bool Next;
    public TextMeshProUGUI bosta;
    public GameObject desenho;
    public bool a = false;
    public bool b;
    public bool c;
    public bool d;
    public bool e;
    public bool f;
    public bool g;
    public bool h;
    public bool i;
    public bool j;
    public bool k;
    public bool l;
    public bool m;
    public bool n;
    public bool o;
    public bool p;
    public bool q;
    public bool r;
    public bool s;
    public bool t;


    void Start()
    {
        Tela.fillAmount = 0;
        Text.SetActive(false);
        Bottons.SetActive(false);
        Diario_text.SetActive(false);
        desenho.SetActive(false);
    }
        void Update()
        {
            if (Next == false)
            {
                Invoke("Cycle2", 0);
            }
            if (Next == true)
            {
                Invoke("Cycle1", 0);
            }
        }
        void Cycle1()
        {
            Tela.fillAmount = 0;
            Text.SetActive(false);
            Bottons.SetActive(false);
            Diario_text.SetActive(false);


            Next = false;
        }
        void Cycle2()
        {

   
            
            if (b == true)
            {
                bosta.text = "07/01/2023\r\n\r\nHoje eu vi um vestido bonito, se Yuri estivesse comigo ele me faria provar em segredo, talvez até comprasse e mentiria a eles que era para uma namorada dele. Droga... não faz bem pensar nele, mas sem ele parece ter tudo ficado mais difícil, não consigo comer enquanto encaro o rosto deles.\r\n";
            }
            if (c == true)
            {
                bosta.text = "09/01/2023\r\n\r\nComprei o vestido, tenho escondido ele embaixo do colchão.\r\n";
            }
            if (d == true)
            {
                bosta.text = "17/03/2023\r\n\r\nEu sinto falta do Yuri.\r\n";
            }
            if (e == true)
            {
            bosta.text = "20/03/2023\r\n\r\n\tSinceramente, eu não sei se consigo aguentar mais. Por mais que eu tente quebrar esse padrão, minha mente só continua me dizendo que tudo seria mais fácil se eu seguisse o caminho do Yuri.\r\n\tEu ainda me lembro da imagem. O corpo dele. O sangue.\r\n\tComo meu próprio irmão pode escolher me deixar sozinha com eles? Por que ele fez aquilo?\r\n";
            }
            if (f == true)
            {
                bosta.text = "";
            }
            if (g == true)
            {
                bosta.text = "05/05/2023\r\n\r\n\tEstive pensando em como poderia comprar maquiagem, não sei, seria tão ruim arriscar? O que Yuri faria? \r\n";
            }
            if (h == true)
            {
            bosta.text = "10/06/2023\r\n\r\n\tEu só queria ter a coragem pra poder acabar com tudo logo.\r\n\tPor que é que a minha existência incomoda tanto eles?\r\n\tÉ pedir demais uma vida normal como eu quero? \r\n\tPor que eles me chamam de aberração?\r\n\tO que tem de errado comigo?\r\n\tTudo o que eu quero...\r\n\tNão sei.\r\n";
            }
            Tela.fillAmount += Time.deltaTime * 0.2f;
            if (i == true)
            {
            bosta.text = "25/06/2023\r\n\r\n\tTive um pesadelo estranho hoje. Eu sentia que estava constantemente sendo vigiada por algo.\r\n";
            }
            if(j == true)
            {
            bosta.text = "12/07/2023\r\n\r\n\tComecei a pesquisar como começar a transição, o que primeiro? Psiquiatra? Endocrinologista? Não quero passar por toda a puberdade. Não quero...\r\n";
            }
            if (k == true)
            {
            bosta.text = "13/07/2023\r\n\r\n\tAquela coisa de novo. \r\n\tEu corro dela todas as noites, mas ela sempre volta na hora de dormir.\r\n";
            }
            if (l == true)
            {
            bosta.text = "30/09/2023\r\n\r\n\tHoje faz um ano que o Yuri morreu. \t\r\n\tDevia ter sido eu.\r\n\t\r\n\tQuanto mais o tempo passa, mais eu a vejo... aquela coisa. \r\n\tAcho que ela já é parte de mim.\r\n";
            }
            if (m == true)
            {
            bosta.text = "31/10/2023\r\n\r\n\tHalloween, mas, aparentemente, o único monstro que eles veem na rua sou eu. Os olhares me fazem querer arrancar a minha própria pele.\r\n\tEu não lembro mais como é o meu próprio rosto, meu próprio corpo.\r\n\tEu sinto que fui trazido a esse mundo com o único intuito de sofrer.\r\n\tDeus não existe, eu tenho certeza disso.\r\n\tEles perguntaram mina senha... me bateram quando recusei... Yuri nunca deixaria isso acontecer, mas estou grata de não ver ele apanhar em meu lugar.\r\n\t\r\n\tEncontrei um desenho antigo meu:\r\n";
            }
            if (n == true)
            {
            desenho.SetActive(true);
            }
            float rng = Random.Range(1, 90);
            if (rng >= 1 && rng <= 2)
            {
                Tela.fillAmount += 0.05f;
            }
            if (Tela.fillAmount >= 1)
            {
                Bottons.SetActive(true);
                Text.SetActive(true);
                Diario_text.SetActive(true);
            }



        }

    }

