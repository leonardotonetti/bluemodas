# bluemodas
Este projeto está separado em duas solutions, projeto web e api.
Para rodar a api, será necessário a execução das migrations para a geração da modelagem utilizada pelo projeto.
Para isso, será necessário acessar o arquivo appsettings.json do projeto de api, que fica no seguinte caminho bluemodas/BlueModasApi/BlueModasApi.Api/appsettings.json,
alterar a connection string do sql server sinalizada por "Sua connection string aqui" para a connection string do seu database.


Em seguida, com o visual studio aberto, você deverá abrir a janela do "Package Manager Console". Com a janela iniciada, basta alterar o "Default Project" para BlueModasApi.Data
e em seguida executar o comando Update-Database.
As migrations serão executadas, e nossa modelagem já estará pronta pra ser utilizada pela api.

É isso, agora só rodar a api e a web (:
