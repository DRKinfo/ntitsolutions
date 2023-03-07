

Este � um modelo de solu��o para criar um Single Page App (SPA) com Angular e ASP.NET Core seguindo os princ�pios da Clean Architecture. Crie um novo projeto com base neste modelo clicando no bot�o **Usar este modelo** acima ou instalando e executando o pacote NuGet associado (consulte Introdu��o para obter detalhes completos).

##  Tecnologias

* [ ASP.NET Core 7 ](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [ Entity Framework Core 7 ](https://docs.microsoft.com/en-us/ef/core/)
* [ Angular 14 ](https://angular.io/)
* [ MediatR ](https://github.com/jbogard/MediatR)
* [ AutoMapper ](https://automapper.org/)
* [ FluentValidation ](https://fluentvalidation.net/)
* [ NUnit ](https://nunit.org/), [ FluentAssertions ](https://fluentassertions.com/), [ Moq ](https://github.com/moq) & [ Respawn ](https: //github.com/jbogard/Respawn)

###  Configura��o do banco de dados

O modelo � configurado para usar um banco de dados na mem�ria por padr�o. Isso garante que todos os usu�rios possam executar a solu��o sem a necessidade de configurar infraestrutura adicional (por exemplo, SQL Server).

Se voc� quiser usar o SQL Server, ser� necess�rio atualizar **WebUI/appsettings.json** da seguinte maneira:

```json
  "UseInMemoryDatabase" : falso ,
```

Verifique se a string de conex�o **DefaultConnection** em **appsettings.json** aponta para uma inst�ncia v�lida do SQL Server.

Ao executar o aplicativo, o banco de dados ser� criado automaticamente (se necess�rio) e as �ltimas migra��es ser�o aplicadas.

###  Migra��es de banco de dados

Para usar `dotnet-ef` para suas migra��es, primeiro certifique-se de que "UseInMemoryDatabase" esteja desabilitado, conforme descrito na se��o anterior.
Em seguida, adicione os seguintes sinalizadores ao seu comando (os valores assumem que voc� est� executando a partir da raiz do reposit�rio)

*  `--project src/Infrastructure` (opcional se estiver nesta pasta)
*  `--startup-project src/WebUI`
*  `--output-dir Persistence/Migrations`

Por exemplo, para adicionar uma nova migra��o da pasta raiz:

 `dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations`

##  Vis�o geral

###  Dom�nio

Isso conter� todas as entidades, enums, exce��es, interfaces, tipos e l�gica espec�ficos da camada de dom�nio.

###  Aplica��o

Essa camada cont�m toda a l�gica do aplicativo. � dependente da camada de dom�nio, mas n�o possui depend�ncias de nenhuma outra camada ou projeto. Essa camada define interfaces que s�o implementadas por camadas externas. Por exemplo, se o aplicativo precisar acessar um servi�o de notifica��o, uma nova interface seria adicionada ao aplicativo e uma implementa��o seria criada dentro da infraestrutura.

###  Infraestrutura

Essa camada cont�m classes para acessar recursos externos, como sistemas de arquivos, servi�os da web, smtp e assim por diante. Essas classes devem ser baseadas em interfaces definidas na camada de aplicativo.

###  WebUI

Essa camada � um aplicativo de p�gina �nica baseado em Angular 14 e ASP.NET Core 7. Essa camada depende das camadas de Aplicativo e Infraestrutura, no entanto, a depend�ncia de Infraestrutura � apenas para dar suporte � inje��o de depend�ncia. Portanto, apenas *Startup.cs* deve fazer refer�ncia � infraestrutura.

##  Licen�a

Este projeto est� licenciado com a [ licen�a MIT ](LICENSE).