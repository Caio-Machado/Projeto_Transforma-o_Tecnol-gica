using System;

class MainClass {

  //Caso uma pergunta seja feita e depois analizada, outras respostas serão adicionadas à anterior.

  public static void Main (string[] args) {
    bool sentinela = true;

    Empresa questionario = new Empresa();
    Processamento metods_process = new Processamento();


    while (sentinela == true) {
      Console.WriteLine("O que deseja fazer:\n1 - Criar pergunta e respostas\n2 - Editar Pergunta ou Respostas\n3 - Responder a pergunta\n4 - Ver análize das respostas\n5 - Sair");
    
      switch (int.Parse(Console.ReadLine())) {
        
        //Caso para criar a pergunta e suas respostas.
        case 1:
          //Alterando Pergunta.
          Console.WriteLine("Digite Qual pergunta deseja salvar:");
          questionario.set_Pergunta();

          //Feedback
          Console.WriteLine("Sua pergunta agora é {0}",questionario.get_Pergunta());

          //Alterando Respostas.
          questionario.set_Resp_1();
          questionario.set_Resp_2();
          questionario.set_Resp_3();

          Console.WriteLine("Suas Respostas São:\n1 - {0}\n2 - {1}\n3 - {2}", questionario.get_Resp_1(), questionario.get_Resp_2(), questionario.get_Resp_3());
          break;

        //Caso para editar ou a pergunta ou alguma das Respostas.
        case 2:
          int perg_resp;
          
          Console.WriteLine("Você deseja editar:\n1 - Pergunta\n2 - Respostas");
          perg_resp = int.Parse(Console.ReadLine());

          //Condicional para Caso a resposta do usuário seja editar a pergunta.
          if (perg_resp == 1) {
            questionario.set_Pergunta();
            Console.WriteLine("Sua pergunta agora é {0}",questionario.get_Pergunta());
            break;
          }

          //Condicional para Caso a resposta do usuário seja editar alguma resposta.
          else {
            if (perg_resp == 2) {
              Console.WriteLine("Escolha qual resposta deseja editar:\n1 - Primeira, atualmente é: {0}\n2 - Segunda, atualmente é: {1}\n3 - Terceira, atualmente é: {2}", questionario.get_Resp_1(), questionario.get_Resp_2(), questionario.get_Resp_3());
              switch (int.Parse(Console.ReadLine())) {
                //Caso que altera a resposta 1 + Feedback da alteração.
                case 1:
                  questionario.set_Resp_1();
                  Console.WriteLine("Sua nova Primeira resposta é {0}", questionario.get_Resp_1());
                  break;
                
                //Caso que altera a resposta 1 + Feedback da alteração.
                case 2:
                  questionario.set_Resp_2();
                  Console.WriteLine("Sua nova Segunda resposta é {0}", questionario.get_Resp_2());
                  break;
              
                //Caso que altera a resposta 1 + Feedback da alteração.
                case 3:
                  questionario.set_Resp_3();
                  Console.WriteLine("Sua nova Terceira resposta é {0}", questionario.get_Resp_3());
                  break;
              }
            }
          }
          break;

        //Caso para que seja possível Fazer uma simulação de resposta para a pergunta.
        case 3:
          int sentinela_2 = 1;

          while (sentinela_2 == 1) {
            metods_process.RespondeQ(questionario.get_Pergunta(), questionario.get_Resp_1(), questionario.get_Resp_2(), questionario.get_Resp_3());

            Console.WriteLine("Deseja responder mais uma vez?\n1 - Sim\n2 - Não ");
            sentinela_2 = int.Parse(Console.ReadLine());

            if (sentinela_2 == 1) {
              continue;
            }

            else if (sentinela_2 == 2) {
              sentinela_2 = 2;
              break;
            }
          }
          break;

        //Caso que mostrará as porcentagens e a resposta com mais votos.
        case 4:
          Console.WriteLine("Os resultados finais ficaram:\n{0} - {1}%\n{2} - {3}%\n{4} - {5}%",questionario.get_Resp_1(), metods_process.get_porcentagem_1(), questionario.get_Resp_2(), metods_process.get_porcentagem_2(), questionario.get_Resp_3(), metods_process.get_porcentagem_3());

          metods_process.DeterminaMaior(questionario.get_Resp_1(), questionario.get_Resp_2(), questionario.get_Resp_3());

          Console.WriteLine("A resposta mais escolhida foi ({0}) com {1}%.",metods_process.get_nome_maior(), metods_process.get_porcentagem_maior());
          break;

        //Caso para encerra o while
        case 5:
          sentinela = false;
          break;
      }
    }
  }
}