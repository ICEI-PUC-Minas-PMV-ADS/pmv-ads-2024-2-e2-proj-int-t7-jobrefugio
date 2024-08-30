# Especificações do Projeto

## Perfis de Usuários

<table>
<tbody>
<tr>
<th colspan="2">Perfil 01: Refugiado </th>
</tr>
<tr>
<td width="150px"><b>Descrição</b></td>
<td width="600px">
Indivíduos que buscaram refúgio no Brasil devido a crises em seus países de origem, e que estão em busca de emprego e oportunidades de capacitação para integrarem a sociedade 
</td>
</tr>
<tr>
<td><b>Necessidades</b></td>
<td>
1. Acesso a vagas de emprego adequadas ao seu perfil profissional.<br>
2. Acesso a programas de capacitação e aprendizado.<br>
3. Ser orientado quanto ao seu posicionamento frente ao mercado de trabalho brasileiro.<br>
4. Necessidade de renda para custear as suas necessidades e de sua família. 
</td>
</tr>
</tbody>
</table>

<br>

<table>
<tbody>
<tr>
<th colspan="2">Perfil 02: Empregador </th>
</tr>
<tr>
<td width="150px"><b>Descrição</b></td>
<td width="600px">
Empresas que queiram aderir a colocação de refugiados no mercado de trabalho brasileiro com divulgação de vagas de emprego no sistema  
</td>
</tr>
<tr>
<td><b>Necessidades</b></td>
<td>
1. Preenchimento das vagas de seu quadro funcional.<br>
2. Fazer parte de um programa que promove cidadania.<br>
3. Publicar e gerenciar vagas de emprego.<br>
4. Acesso a página de candidatos que atendam suas necessidades especificas.<br> 
</td>
</tr>
</tbody>
</table>

## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.


## Histórias de Usuários


|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Refugiado          |Criar um perfil no sistema   | Para me candidatar as vagas |
|Refugiado          |Encontrar vagas de emprego  | Candidatar a vagas disponíveis|
|Refugiado          |Me inscrever em cursos de idioma oferecidos pelo sistema  | Melhorar minhas habilidades linguísticas e facilitar minha integração |
|Refugiado          |Criar e editar meu currículo  | Para atualizar minhas informações |
|Refugiado          |Receber notificações de novas vagas de emprego | Para aproveitar oportunidades recém cadastradas |
|Refugiado          |Receber alerta de entrevista | Saber quando a empresa confirmar entrevista |
|Refugiado          |Consultar as Ongs disponíveis para suporte das minhas dificuldades | Receber auxilio nos problemas enfrentados no país |
|Empregador   |Publicar vagas de emprego na plataforma  | Contratar novos profissionais |
|Empregador   |Filtrar candidatos com base em habilidades e experiências | Realizar uma melhor escolha do candidato que melhor se encaixe na vaga   |
|Empregador   |Fazer parte das empresas parceiras do projeto | Ajudar na redução das desigualdades no mercado de trabalho |
|Empregador   |Excluir vaga que já foi preenchida  | Correção de erros |
|Empregador   |Editar vagas e competências   | Escolher o curso certo |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário avalie uma agência de intercâmbio com base na sua experiência| ALTA | 
|RF-002| A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de intercâmbio    | ALTA |
|RF-003| A aplicação deve permitir que o usuário consulte todas as agências de intercâmbio cadastradas ordenando-as com base em suas notas | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
