# Funcionalidade de Seleção de Cor

Este diretório contém a lógica de back-end para a funcionalidade de seleção de cores no VeraxCAD 2D.

## Classes

### `Cor`

A struct `Cor` foi expandida para incluir métodos de conversão entre os formatos de cores RGB, HEX e HSV.

**Exemplos de Uso:**

```csharp
// Criar uma cor a partir de RGB
var corRgb = new Cor(255, 0, 0);

// Converter para HEX
string hex = corRgb.ToHex(); // Retorna "#FF0000"

// Converter para HSV
var (h, s, v) = corRgb.ToHsv();

// Criar uma cor a partir de HEX
var corHex = Cor.FromHex("#FF0000");

// Criar uma cor a partir de HSV
var corHsv = Cor.FromHsv(0, 1, 1);
```

### `ColorSelector`

A classe `ColorSelector` atua como um controlador para a interface de seleção de cores. Ela gerencia a cor selecionada e fornece métodos para atualizá-la a partir de diferentes escalas de cores (RGB, HEX, HSV), tratando automaticamente a formatação.

**Exemplos de Uso:**

```csharp
// Inicializar o seletor com uma cor
var seletor = new ColorSelector(Cor.Vermelho);

// Obter a cor em diferentes formatos de string
string rgbString = seletor.GetRgbString(); // "255,0,0"
string hexString = seletor.GetHexString(); // "#FF0000"
string hsvString = seletor.GetHsvString(); // "0°,100%,100%"

// Definir a cor a partir de strings formatadas
seletor.SetFromRgbString("0,255,0");
seletor.SetFromHexString("#0000FF");
seletor.SetFromHsvString("0°,100%,100%");
```

## Interface do Usuário (UI)

A implementação da interface do usuário (UI), incluindo o círculo cromático e a caixa de texto, não foi incluída. Esta implementação contém apenas a lógica de back-end. A UI precisará ser desenvolvida separadamente e conectada a esta lógica.
