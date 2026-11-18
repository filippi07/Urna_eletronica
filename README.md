## Aviso

Não foram usados nomes de partidos, siglas ou fotos de pessoas reais. Todos os dados são fictícios, a imagem usada nos candidatos e eleitores é a do personagem Relâmpago McQueen, do filme Carros.

# Simulação de Urna Eletrônica Brasileira

Projeto da disciplina de Desenvolvimento para Desktops (Sistemas de Informação, Uniara).
O sistema simula a operação de uma urna eletrônica do 1º turno, com votação para Deputado Estadual,
Deputado Federal, 2 Senadores, Governador e Presidente.

## Tecnologias

- C# com Windows Forms (.NET Framework)
- Newtonsoft.Json (leitura e gravação dos arquivos JSON)
- Sem banco de dados: tudo é processado em memória

## Como funciona

### Parte 1: Carregamento
- Lê `CANDIDATOS.JSON` e `ELEITORES.JSON` da pasta do executável, sem travar a interface.
- Exibe a etapa atual e o percentual de conclusão em uma barra de progresso.
- Emite a `ZEREZIMA.TXT`, confirmando 0 votos para todos os cargos.
- Ao concluir, avança para a identificação e não há como voltar.

### Parte 2: Votação
- **Identificação:** o eleitor informa o título e depois a biometria (8 caracteres alfanuméricos).
  Após 5 tentativas incorretas de biometria, volta para a digitação do título.
- **Votação:** ordem fixa de cargos (Deputado Estadual, Deputado Federal, Senador 1º voto,
  Senador 2º voto, Governador e Presidente), com teclado numérico, botões BRANCO, CORRIGE e CONFIRMA.
- Voto em legenda para deputados (2 dígitos do partido), voto branco e voto nulo.
- Exibição dinâmica: sigla e nome do partido ao digitar o prefixo; foto, nome e partido do candidato
  (e vice ou suplentes) ao completar o número.
- Ao final do último cargo, exibe "FIM", registra o eleitor e volta para a identificação.
- Os votos de cada cargo e a lista de eleitores que votaram são embaralhados (Fisher-Yates)
  após cada votação, para garantir o sigilo.

### Parte 3: Encerramento
- O botão "Encerrar votação" grava `VOTOS.JSON` e `ELEITORES_QUE_VOTARAM.JSON`.
- Gera o `BOLETIM_DE_URNA.TXT` com os votos por candidato (só os que receberam votos),
  votos em legenda, votos brancos e nulos por cargo, e o balanço entre eleitores e votos.
- Se houver divergência entre eleitores e votos em algum cargo, o boletim traz um alerta de inconsistência.
- Ao final, descarta os dados da memória e encerra a aplicação.

## Estrutura do projeto

- `Models/`: classes `Pessoa`, `Candidato` e `Eleitor`
- `Urna`: dados em memória (candidatos, eleitores, votos), embaralhamento, exportação, boletim
- `Frm_Carregamento`: tela de carregamento (Parte 1)
- `Frm_Identificacao`: título e biometria (Parte 2A)
- `Frm_Urna`: tela de votação (Parte 2B)
- `GeradorDados`: gera os JSONs de teste (135 candidatos e 30 eleitores)

## Arquivos de entrada e saída

| Arquivo | Tipo | Descrição |
|---|---|---|
| `CANDIDATOS.JSON` | Entrada | 50 Dep. Estaduais, 50 Dep. Federais, 20 Senadores, 10 Governadores, 5 Presidentes |
| `ELEITORES.JSON` | Entrada | 30 eleitores com título, foto e biometria |
| `ZEREZIMA.TXT` | Saída | Gerado ao fim da Parte 1 |
| `VOTOS.JSON` | Saída | Listas de votos por cargo (embaralhadas) |
| `ELEITORES_QUE_VOTARAM.JSON` | Saída | Eleitores que votaram (embaralhados) |
| `BOLETIM_DE_URNA.TXT` | Saída | Apuração e verificação de inconsistências |

## Autores

- Filippi Afonso Ferreira Leite
- Vinicius de Oliveira Magno
- Pedro Paulo Alves Rampinelli Filho
