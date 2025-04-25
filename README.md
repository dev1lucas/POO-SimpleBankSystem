
# 💳 Desafio de Programação Orientada a Objetos em C#

Este projeto é um exercício prático com foco em **Programação Orientada a Objetos (POO)** utilizando a linguagem **C#**.

## 📌 Objetivo

Criar e utilizar **construtores** para as classes `Titular` e `Conta`, instanciar um objeto da classe `Conta`, e exibir as informações da conta de forma formatada.

---

## 📂 Estrutura do Projeto

### 📁 Classes

#### 🔸 Titular

```csharp
class Titular
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }

    // Construtor
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
}
```

#### 🔸 Conta

```csharp
class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; private set; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    // Construtor
    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }
}
```

---

## 🧪 Demonstração de Uso

```csharp
var titular = new Titular("Lucas Araújo", "123.456.789-00", "Rua das Flores, 123");
var conta = new Conta(titular, 1234, 567890, 1500.00, 500.00);

Console.WriteLine(conta.Informacoes);
```

---

## ✅ O que foi praticado

- Criação de **construtores personalizados**
- Utilização de **propriedades automáticas**
- **Encapsulamento** e **composição de objetos**
- Formatação de strings usando interpolação
- Instanciação de objetos em C#

---

## 🧠 Autor

Desenvolvido por **Lucas dos Santos Araújo** como parte do processo de aprendizado em C# e orientação a objetos.

- [LinkedIn](https://www.linkedin.com/in/lucas-santos-5a4675227)
- [GitHub](https://github.com/dev1lucas)

---

## 📜 Licença

Este projeto está sob a licença MIT.
