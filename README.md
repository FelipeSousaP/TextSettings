# TextSetting1_0

Uma biblioteca utilitária para **C# Console Applications** que permite manipular a exibição de textos de forma elegante, adicionando cores, efeitos de digitação e posicionamento personalizado.

## 📝 Definição

A classe `TextSetting` foi criada para simplificar a interface de usuário em modo console. Em vez de lidar manualmente com coordenadas de cursor, threads e cores do sistema, você pode usar uma única linha de comando para criar interfaces mais dinâmicas e atraentes.

## ⚙️ Funcionalidades

* **Efeito Typewriter:** Controle de velocidade (delay) caractere por caractere.
* **Posicionamento:** Define a linha específica (`top`) onde o texto deve aparecer.
* **Colorização:** Suporte total às cores nativas do `ConsoleColor`.
* **Centralização Inteligente:** Calcula automaticamente o meio da tela com base na largura da janela do console.
* **Gestão de Erros:** Tratamento interno para evitar falhas por parâmetros inválidos ou fora dos limites do console.

## 🚀 Como Implementar / Instalar

### 1. Pré-requisitos
* **.NET SDK** instalado.
* Um projeto do tipo **Console Application**.

### 2. Integração
Copie o arquivo `TextSetting.cs` para o seu projeto e certifique-se de que ele esteja sob o namespace:
```csharp
namespace TextSetting1_0
```

## Exemplos
```csharp
using TextSetting1_0;
TextSetting.Sentence("Bem-vindo ao Sistema!", 50, 2, ConsoleColor.Cyan);
TextSetting.Sentence("PROJETO FINALIZADO", 30, 10, ConsoleColor.Green, true);
