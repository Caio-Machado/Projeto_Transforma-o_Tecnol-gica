using System;

/* Aqui ficará a escolha da(s) pergunta(s) a serem feitas ao usuário. A ideia principal é ter mais de uma pergunta e elas forem armazenadas com o passar do tempo, mas por enquanto a pergunta é fixa com três respostas possíveis.*/

class Empresa {
  //Como ja foi mensionado esse protótipo possuí quantidade de respostas fixas. (As Variáveis estão atribuidas como STATIC porque precisam ser acessadas pelos métodos de SET's e GET's, que depois serão acessados pela classe main.)

  //Não é possível utiliza-las sem static.
  private string pergunta;
  private string resp_1;
  private string resp_2;
  private string resp_3;

  //SET's
  public void set_Pergunta () {
    Console.WriteLine("Qual a pergunta a ser feita: ");
    pergunta = Console.ReadLine();
  }

  public void set_Resp_1 () {
    Console.WriteLine("Qual a primeira resposta: ");
    resp_1 = Console.ReadLine();
  }

  public void set_Resp_2 () {
    Console.WriteLine("Qual a segunda resposta: ");
    resp_2 = Console.ReadLine();
  }

  public void set_Resp_3 () {
    Console.WriteLine("Qual a terceira resposta: ");
    resp_3 = Console.ReadLine();
  }

  //GET's
  public string get_Pergunta () {
    return pergunta;
  }

  public string get_Resp_1 () {
    return resp_1;
  }

  public string get_Resp_2 () {
    return resp_2;
  }

  public string get_Resp_3 () {
    return resp_3;
  }
}