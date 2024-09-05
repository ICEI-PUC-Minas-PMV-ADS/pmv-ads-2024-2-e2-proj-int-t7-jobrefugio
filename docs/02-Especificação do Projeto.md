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

As personas criadas durante o processo de levantamento de requisitos são apresentadas nas figuras abaixo.
<figure> 
  <img src="/docs/img/persona 1.png">
</figure> 

<figure> 
  <img src="/docs/img/persona 2.png">
</figure> 

<figure> 
  <img src="/docs/img/persona 3.png">
</figure> 

<figure> 
  <img src="/docs/img/persona 4.png">
</figure> 

<figure> 
  <img src="/docs/img/persona 5.png">
</figure> 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

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
|RF-001| O site deve permitir gerenciar usuário  | ALTA | 
|RF-002| Permitir fazer pesquisas de vagas disponíveis  | ALTA |
|RF-003| Realizar a indicação de cursos   | ALTA |
|RF-004| Permitir a criação de currículos com base no cadastro     | MÉDIA |
|RF-005| Notificar usuário sobre novas vagas    | MÉDIA |
|RF-006| Notificar usuário sobre entrevista     | MÉDIA |
|RF-007| Permitir consultas de ONGS regulamentadas para capacitação    | ALTA |
|RF-008| Permitir que a empresa cadastre vagas de emprego    | ALTA |
|RF-009| Permitir a empresa filtrar candidatos     | ALTA |
|RF-010| Exibir lista de empresas parceiras do projeto    | MÉDIA |
|RF-011| Permitir que a empresa exclua a vaga já preenchida    | ALTA |
|RF-012| Permitir que a empresa edite a vaga divulgada no sistema    | ALTA |

**Prioridade: Alta / Média / Baixa.

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve garantir a segurança e privacidade dos dados dos usuários  | ALTA | 
|RNF-002| A aplicação deve ter visualização responsiva adequada em desktops, tablets e celulares  |  MÉDIA | 
|RNF-003| Compatibilidade com sistemas operacionais (Windows, Linux, IOS e Android)   | ALTA |
|RNF-004| O site deve ser compatível com os principais navegadores Google Chrome, Firefox e Microsoft Edge    | ALTA |
|RNF-005| A Aplicação deve funcionar 7 dias por semana e em 24 horas     | ALTA |
|RNF-006| O sistema deve permitir migrar para novas plataformas     | MÉDIA |
|RNF-007| O sistema deve se recuperar de falhas no máximo em 2 segundos    | ALTA |

**Prioridade: Alta / Média / Baixa.


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

![casoDeUsoJobRefugio](https://github.com/user-attachments/assets/45bcfdca-26d5-479c-9c05-bcefa0b31464)
