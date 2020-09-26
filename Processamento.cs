using System;

class Processamento {

  /*Aqui ficará os métodos que manipularão os resultados dos votos.*/

  private string nome_maior;
  private double total_maior;
  private double total_resp_1;
  private double total_resp_2;
  private double total_resp_3;
  private double total_participantes;

  //Método para determinar a resposta com maior quantidade de votos e seu nome.
  public void DeterminaMaior (string nome_1,string nome_2,string nome_3) {
    total_maior = total_resp_1;
    nome_maior = nome_1;

    if (total_maior < total_resp_2) {
      total_maior = total_resp_2;
      nome_maior = nome_2;
    }

    else if (total_maior < total_resp_3) {
      total_maior = total_resp_3;
      nome_maior = nome_3;
    }
    
  }

  //Método para recolher as respostas, armazena-las, determinar o total de participantes e determinar a resposta mais votada.
  public void RespondeQ (string questionario_perg, string questionario_resp_1, string questionario_resp_2, string questionario_resp_3) {


    Console.WriteLine(questionario_perg);
    Console.WriteLine("1 - {0}",questionario_resp_1);
    Console.WriteLine("2 - {0}",questionario_resp_2);
    Console.WriteLine("3 - {0}",questionario_resp_3);

    Console.WriteLine("Qual a Sua resposta? ");
    int resposta = int.Parse(Console.ReadLine());

    //Contagem dos votos
    switch (resposta) {
      case 1:
        total_resp_1++;
        total_participantes++;
        break;
      
      case 2:
        Console.WriteLine("Entrei2");
        total_resp_2++;
        total_participantes++;
        break;
      
      case 3:
        Console.WriteLine("Entrei3");
        total_resp_3++;
        total_participantes++;
        break;

      DeterminaMaior(questionario_resp_1,questionario_resp_2,questionario_resp_3);
    }
  }


  //GET's
  //Todos os GET's de porcentagem retornam o valor ja calculado diretamente para porcentagem.
  public double get_porcentagem_maior () {
    return (total_maior/total_participantes)*100;
  }

  public double get_porcentagem_1 () {
    return (total_resp_1/total_participantes)*100;
  }

  public double get_porcentagem_2 () {
    return (total_resp_2/total_participantes)*100;
  }

  public double get_porcentagem_3 () {
    return (total_resp_3/total_participantes)*100;
  }

  //public double get_Maior () {
    //return total_maior;
  //}

  //Método que retorna o nome da resposta com mais votos.
  public string get_nome_maior () {
    return nome_maior;
  }
}