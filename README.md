

Este é um modelo de solução para criar um Single Page App (SPA) com Angular e ASP.NET Core seguindo os princípios da Clean Architecture. Crie um novo projeto com base neste modelo clicando no botão **Usar este modelo** acima ou instalando e executando o pacote NuGet associado (consulte Introdução para obter detalhes completos).

##  Tecnologias

* [ ASP.NET Core 7 ](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [ Entity Framework Core 7 ](https://docs.microsoft.com/en-us/ef/core/)
* [ Angular 14 ](https://angular.io/)
* [ MediatR ](https://github.com/jbogard/MediatR)
* [ AutoMapper ](https://automapper.org/)
* [ FluentValidation ](https://fluentvalidation.net/)
* [ NUnit ](https://nunit.org/), [ FluentAssertions ](https://fluentassertions.com/), [ Moq ](https://github.com/moq) & [ Respawn ](https: //github.com/jbogard/Respawn)

###  Configuração do banco de dados

O modelo é configurado para usar um banco de dados na memória por padrão. Isso garante que todos os usuários possam executar a solução sem a necessidade de configurar infraestrutura adicional (por exemplo, SQL Server).

Se você quiser usar o SQL Server, será necessário atualizar **WebUI/appsettings.json** da seguinte maneira:

```json
  "UseInMemoryDatabase" : falso ,
```

Verifique se a string de conexão **DefaultConnection** em **appsettings.json** aponta para uma instância válida do SQL Server.

Ao executar o aplicativo, o banco de dados será criado automaticamente (se necessário) e as últimas migrações serão aplicadas.

###  Migrações de banco de dados

Para usar `dotnet-ef` para suas migrações, primeiro certifique-se de que "UseInMemoryDatabase" esteja desabilitado, conforme descrito na seção anterior.
Em seguida, adicione os seguintes sinalizadores ao seu comando (os valores assumem que você está executando a partir da raiz do repositório)

*  `--project src/Infrastructure` (opcional se estiver nesta pasta)
*  `--startup-project src/WebUI`
*  `--output-dir Persistence/Migrations`

Por exemplo, para adicionar uma nova migração da pasta raiz:

 `dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations`

##  Visão geral

###  Domínio

Isso conterá todas as entidades, enums, exceções, interfaces, tipos e lógica específicos da camada de domínio.

###  Aplicação

Essa camada contém toda a lógica do aplicativo. É dependente da camada de domínio, mas não possui dependências de nenhuma outra camada ou projeto. Essa camada define interfaces que são implementadas por camadas externas. Por exemplo, se o aplicativo precisar acessar um serviço de notificação, uma nova interface seria adicionada ao aplicativo e uma implementação seria criada dentro da infraestrutura.

###  Infraestrutura

Essa camada contém classes para acessar recursos externos, como sistemas de arquivos, serviços da web, smtp e assim por diante. Essas classes devem ser baseadas em interfaces definidas na camada de aplicativo.

###  WebUI

Essa camada é um aplicativo de página única baseado em Angular 14 e ASP.NET Core 7. Essa camada depende das camadas de Aplicativo e Infraestrutura, no entanto, a dependência de Infraestrutura é apenas para dar suporte à injeção de dependência. Portanto, apenas *Startup.cs* deve fazer referência à infraestrutura.

##  Licença

Este projeto está licenciado com a [ licença MIT ](LICENSE).