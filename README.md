# Sistema de Pontos de Fidelidade

Este projeto implementa um sistema simples de fidelidade em C#. Ele permite que um cliente acumule pontos ao fazer compras e resgate pontos posteriormente, garantindo que o saldo nunca fique negativo. Cada R$ 1 em compras gera 1 ponto.

## Funcionalidades

- **Acumular pontos:** registra o valor da compra e converte em pontos.
- **Resgatar pontos:** permite o resgate se houver pontos suficientes.
- **Visualizar saldo:** mostra o saldo atual de pontos.

## Estrutura do código

- `ClienteFidelidade.cs` – classe que encapsula o saldo de pontos e fornece métodos `AdicionarCompra` (para acumular pontos) e `ResgatarPontos` (para resgatar).
- `Program.cs` – aplicativo de console que exibe um menu para registrar compras, resgatar pontos ou ver o saldo.
- `ClienteFidelidade.csproj` – arquivo de projeto .NET configurado para C# 10 no .NET 7, com nullable habilitado e implicit usings.

## Como executar

1. Garanta que o .NET 7 SDK esteja instalado em sua máquina.
2. Clone este repositório ou baixe os arquivos do projeto.
3. No terminal, navegue até a pasta do projeto e execute:

```
 dotnet run
```

O programa exibirá um menu interativo que permite registrar compras (informando o valor em reais), resgatar pontos (informando a quantidade) ou consultar o saldo atual. A classe `ClienteFidelidade` protege o saldo, não permitindo resgatar mais pontos do que o acumulado, e lança exceções para valores negativos.
