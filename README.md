# dotnet-mongo melhorado


Exemplo de aplicação .net core com mongodb com CRUD.

Do projeto original do Gabriel Faraday
https://github.com/gabrielfbarros/dotnet-mongo

 Foi adicionado:

-- Adicionado Id do infectado com id sendo gerado pelo mongodb .
-- Método Put update atualização do infectado de todos seus campos filtrado pelo id.
-- Método Delete deleta documento da collection infectado pelo id.
-- Método Get busca documento da collection infectado pelo id.
-- Foram alterados a geolocalização para os campos estado e cidade.

Para teste:

https://localhost:5001/infectado

```json
{
	"dataNascimento": "1990-03-01",
	"sexo": "M",
	"estado": "Rio de  Janeiro",
	"cidade": "Duque de Caxias"
}
```
OBS: é preciso ter configurar o acesso ao banco no appsettings.

Links Uteis:

- .net core - https://dotnet.microsoft.com/download

- visual code - https://code.visualstudio.com/download

- postman - https://www.postman.com/downloads/

- mongo atlas - https://www.mongodb.com/cloud/atlas/register


-----------------------------------------------

Referências:

https://docs.mongodb.com/

https://docs.mongodb.com/manual/

https://docs.mongodb.com/ecosystem/drivers/csharp/

https://docs.atlas.mongodb.com/
