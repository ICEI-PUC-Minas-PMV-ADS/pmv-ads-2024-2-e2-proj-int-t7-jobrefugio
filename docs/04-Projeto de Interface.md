
# Projeto de Interface

O projeto de interface foi desenvolvido para mostrar a interação do usuário com o site e as funcionalidades que fazem parte do sistema. 

## Diagrama de Fluxo

O diagrama abaixo apresenta o fluxo de interação dos usuários com o sistema, desde o login até o cadastro de uma vaga na visão do candidato e inclusão de vagas por parte do empregador. Garantindo assim assertividade no processo e auxiliando no planjamento e construção das telas do sistema que serão explicadas na sequência.

<img src ="/docs/img/Fluxograma.PNG">

## Wireframes

O wireframe do projeto foi desenvolvido pensando no design de interface de cada tela e as necessidades das histórias dos usuários.

![Interface](https://github.com/user-attachments/assets/366e5afc-df78-4a34-8899-38a79717c84c)


### Tela - Home
A tela Home da aplicação será onde os usuários poderão interagir com o site, a página foi dividida em cabeçalho, conteúdo e rodapé. No cabeçalho consta a logo no lado esquerdo, botões para remeter o usuário para outras páginas da aplicação e no lado direito tem a opção de fazer o cadastro ou login. Os itens do cabeçalho serão mantidos como padão em todas as telas.

No corpo da página, temos um banner que irá trazer os destaques do site e logo abaixo alguns cards que ira permitir o candidato a vizualizar algumas vagas disponiveis na aplicação. Teremos tambem um espaço dedicado a mostrar as empresas parceiras da aplicação que disponibilizam as vagas.

No rodapé irá conter informações de contato e rede social do projeto.

<img src ="/docs/img/HOME.PNG">

### Tela - Sobre nós
A tela Sobre nós da aplicação irá descrever um pouco sobre os criadores da aplicação. Na lateral direita traz um figura representando o projeto.

<img src ="/docs/img/SOBRE NÓS.PNG">

### Tela - Login
A tela de Login apresenta os campos e-mail e senha, e a opção de fazer um novo cadastro.

- O campo **E-mail** permite que o usuário informe seu e-mail cadastrado no site.
- O campo **Senha** permite que informe sua senha cadastrada no site.
- O botão **Fazer Login** permite que ao ser clicado o usuário seja validado pelo sistema após preencher os campos e-mail e senha.
- O botão **Quero me cadastra** irá direcionar o usuário para fazer o cadastro no site.

<img src ="/docs/img/LOGIN.PNG">

### Tela - Criar conta de candidatos refugiados e empresa
Na tela de criar conta terá o dois botões onde o usuários poderá se cadastrar na aplicação com as opções de candidato em busca de uma vaga ou como empresa que irá disponibilizar as vagas.

<img src ="/docs/img/CADASTRO.PNG">

### Tela - Cadastro da empresa
Na tela de cadastro da empresa será disponibilizado os campos para o representante da empresa preencher, realizar o cadastro e usar a aplicação disponibilizando as vagas.

- O campo **Nome da Empresa** permite que o usuário informe o nome Empresarial.
- O campo **Titulo do Estabelecimento** permite que o usuário informe o nome fantasia da empresa.
- O campo **CNPJ** permite que o usuário informe o Cnpj da empresa.
- O campo **Descrição** sobre a empresa permite que o usuário informe uma breve descrição sobre a empresa.
- O campo **endereço** completo permite que o usuário informe os dados de endereço da empresa.
- O campo **CEP** permite que o usuário informe o Cep do endereço da empresa.
- o campo **E-mail** permite que o usuário informe o e-mail da empresa.
- O campo **Telefone** permite que o usuário informe o número de telefone da empresa.
- O campo **Digite sua senha** permite que o usuário informe a senha que deseja cadastrar.
- O campo **Confirme** sua senha permite que o usuário confirme sua senha.
- O botão **Cadastrar** permite que o usuário conclua o cadastro no site.

<img src ="/docs/img/CADASTRO EMPREGADOR.PNG">

### Tela - Perfil Empregador
Na tela perfil do empregador, o usuário que se cadastrar como empresa terá acesso a tela de gerenciar os dados cadastrados, de anunciar uma vaga e tambem gerenciar a mesma e verificar os perfis dos candidatos que se candidataram para uma vaga por ele disponibilizada.

<img src ="/docs/img/PERFIL EMPREGADOR.PNG">

### Tela - Editar dados da Empresa
Na tela Editar dados da Empresa, O usuário poderá editar os dados preenchidos no cadastro inicial. Atende aos requisitos RF-01 e RF-03.

<img src ="/docs/img/EDITAR DADOS EMPRESA.PNG">

### Tela - Vagas incluidas pela empresa
Na tela de vagas o usuário cadastrado como empresa poderá incluir, editar ou excluir conforme definição de requisito RF-11, RF-12 e RF-13. Também poderá consultar os candidatos que se cadidataram para a vaga conforme RF-14. 

- O botão **Nova Vaga** permite que o usuário inclua uma nova vaga no site.
- O botão **Editar Vaga** posicionado na lateral direita do nome da vaga permite que o usuário edite as informaçoes cadastradas da vaga.
- O botão **Excluir Vaga** posicionado na lateral direita do nome da vaga permite que o usuário exclua a vaga cadastrada.
- O botão **Consultar Candidatos** posicionado na parte inferior do card da vaga, permite que o usuário consulte candidatos inscritos na vaga.

<img src ="/docs/img/INCLUSAO VAGA EMPRESA.PNG">

### Tela - Cadastro das vagas
Na tela de cadastro de vagas o usuario cadastrado como empresa irá preencher os campos com as informações para a vaga que ele deseja disponibilizar, campos como: tipo de vaga, descrição, regime de trabalho...

- O campo **Nome do Cargo** permite a empresa descrever o nome do cargo que será divulgado.
- O campo **Local** define o local de trabalho da vaga.
- O campo **Regime de Trabalho** permite a empresa definir se a vaga é presencial, home office ou híbrido.
- O fleg **Vaga para PCD** deverá ser preenchido quando a vaga for inclusiva.
- O campo **Sobre a Empresa** permite descrever mais informações para a empresa.
- O campo **Descrição da Vaga** A empresa poderá detalhar as informações das atividades.
- O campo **Requisitos e Qualificações** permite informar nível de experiência para vaga.
- O campo **Informação Adicional** permite acrescentar dados extras.
- O botão **Salvar** irá salvar e postar a vaga cadastrada.

<img src ="/docs/img/CRIAR VAGA.PNG">

### Tela - Cadastro candidato
Na tela de cadastro de candidato será disponibilizado campos para o candidato preencher com suas informações para realização de cadastro e acesso as vagas disponibilizadas na aplicação.

Campos da página do Candidato:
 
- O campo **Nome Completo** o usuário irá digitar seu nome.
- O campo **Nacionalidade** o usuário irá informar o país de nascimento.
- O campo **Endereço** permite incluir os dados completos de endereço como nome da rua, número, bairro, cidade e CEP- 
- O campo **E-mail** irá trazer a informação do e-mail de login.
- O campo **Telefone** permite que o usuário informe o número do celular com DDD para que seja contato pelo recrutador.
- O campo **CPF/Passaporte** o usuário irá informar um destes dois documentos.
- O campo **Data de Nascimento** o usuário deve preencher com informações com dia, mês e ano de nascimento
- O campo **Digite sua Senha** o usuário deverá criar a senha de acesso a aplicação.
- O campo **Confirme sua Senha** permite que o usuário confirme sua senha.
- O botão **Cadastrar** será efetivado o cadastro do usuário no site
 
<img src ="/docs/img/CADASTRO CANDIDATO.PNG">

### Tela - Perfil do candidato
Na tela perfil do candidato, será possível ter acesso a tela de cadastrar o curriculo, gerenciar os dados, ver as vagas para qual se candidatou e procurar novas vagas.

<img src ="/docs/img/PERFIL CANDIDATO.PNG">

### Tela - Editar perfil do candidato
O usuário cadastrado como candidato poderá gerenciar os dados disponibilizados para o cadastro na aplicação.

<img src ="/docs/img/EDITAR DADOS CANDIDATO.PNG">

### Tela - Crie seu Currículo
Na tela Crie seu currículo, o refugiado poderá cadastrar suas informações bem como editar os campos que achar conveniente seguindo a sequência abaixo de preenchimento e o botão salvar realiza o armazenamento dos dados informados.

- O campo **Nome** permite a digitação do nome completo do refugiado.
- O campo **Idade**  permite ao usuário cadastra sua idade.
- O campo **Nacionalidade**  permite ao usuário  informar sua nacionalidade.
- O campo **Cidade** permite ao usuário o cadastramento da sua cidade.
- O campo **Telefone** permite que o usuário cadastre seu telefone .
- O campo **E-mail** permite que o usuário cadastre seu e-mail.
- O campo **Objetivo profissional**  permite ao  usuário escrever seu objetivo na profissão.
- O campo **Resumo das qualificações** permite  ao usuário cadastrar o resumo das suas. qualificações profissionais.
- O Campo **Principais realizações** permite ao usuário digitar suas principais realizações.
- O campo **Formação acadêmica** permite ao usuário cadastrar suas informações acadêmicas.
- O Campo **Experiência profissional**  permite ao usuário cadastrar sua experiência. profissional.
- O campo **Cursos complementares e idiomas**  permite ao usuário o cadastramento de seus cursos complementares e idiomas.

<img src ="/docs/img/CRIAR CURRICULO.PNG">

### Tela - Consulta de vagas ofertadas
Na tela de consulta de vagas ofertadas o candidato tera acesso as vagas disponibilizadas pelas empresas podendo selecionar a de seu interesse para vizualizar todas as informações sobre a a vaga. Terá a opção de pesquisar por uma vaga em uma área específica e filtrar de acordo tipo de vaga, local e nome da vaga.

- O campo **Nome da Vaga** permite que o usuário visualize o nome da vaga disponível.
- O campo **Empresa** permite que o usuário visualize o nome da empresa que divulgou a vaga.
- O campo **Local** permite que o usuário visualize o local trabalho.
- O campo **Tipo** permite que o usuário visualize o regime de trabalho.
- O campo **Data** permite que o usuário visualize a data da publicação da vaga.
- O botão **Visualizar vaga** permite que o usuário ao clicar visualize a página com a descrição da vaga.

<img src ="/docs/img/VAGAS.PNG">

### Tela - Descrição da vaga
Na tela de descrição da vaga o usuário cadastrado como candidato poderá ver todas as informações disponibilizadas pela a empresa sobre a vaga e candidatar-se a mesma caso deseje.

- O Campo **Nome do Cargo** é apresentada ao usuário a data da publicação, o local, o regime de contratação, método de contratação e se a vaga é para PCD.
- O Campo **Sobre a Empresa** é apresentado ao usuário o a história da empresa, com seus valores, objetivos, missão e o segmento de atuação.
- O Campo **Descrição da vaga** é apresentado ao usuário um breve resumo do cargo e funções a serem desempenhadas.
- O Campo **Requisitos e qualificações** é apresentada ao usuário as informações de qualificações e informações necessárias ao cargo.
- O Campo **Informação adicional** é apresentado ao empregador, informações adicionais da vaga.
  
<img src ="/docs/img/DESCRICAO DA VAGA.PNG">

### Tela - Consulta do status das vagas de sua candidatura (para candidato)
Na tela consulta para status de candidatura da vaga o usuario podera ver todas as vagas para qual se candidatou e ter um breve resumo sobre o status da candidatura, podendo selecionar uma vaga para vizualizar todo o andamento da candidatura.

<img src ="/docs/img/VAGAS INSCRITAS PELO CANDIDATO.PNG"> 

### Tela – Status vaga inscrita
No tela status da vaga inscrita é apresentado ao candidato um resumo do andamento da vaga inscrita e os campos de progresso das etapas até a contratação.

- A Barra de Status poscionada acima da descrição da vaga, permite que o usuário acompanhar o progresso de cada etapa.
- O Campo **Nome do Cargo** é apresentada ao usuário a data da publicação, o local, o regime de contratação, método de contratação e se a vaga é para PCD.
- O Campo **Sobre a Empresa** é apresentado ao usuário o a história da empresa, com seus valores, objetivos, missão e o segmento de atuação.
- O Campo **Descrição da vaga** é apresentado ao usuário um breve resumo do cargo e funções a serem desempenhadas.
- O Campo **Requisitos e qualificações** é apresentada ao usuário as informações de qualificações e informações necessárias ao cargo.
- O Campo **Informação adicional** é apresentado ao empregador, informações adicionais da vaga.
 
<img src ="/docs/img/STATUS VAGA INSC CANDIDATO.PNG">

### Tela - Guia do refugiado com orientações gerais
A tela guia do refugiado irá conter orientações e dicas para ajudar o candidato a se preparar para entrevistas e alguns links de cursos para o candidato adquirir mais qualificação para as vagas.

<img src ="/docs/img/GUIA REFUGIADO.PNG">
