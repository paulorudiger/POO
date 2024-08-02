namespace POO.E1
{
    // Classe -> estrutura que define as características(atributos) e comportamentos (métodos)
    // de um determinado tipo de objeto;
    public class Veiculo
    {
        // Atributos -> característica ou propriedade de um objeto (Veiculo)
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string Placa { get; private set; }

        // Construtor método especial de uma classe que tem a
        // responsabilidade de inicializar um objeto recém criado dessa classe;
        // vai inicializar os atributos: Marca, Modelo, Ano e Placa
        public Veiculo(string marca, string modelo, int ano, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
        }

        // Método - Virtual:  conceito de método virtual está relacionado à sobreescrita de métodos
        // Pode ser sobrescrito nas subclasses para incluir mais detalhes
        // permite que os métodos sejam sobreescritos pelas subclasses, tornando o polimorfismo possível;
        /* 
         polimorfismo é a capacidade de um objeto se comportar de diferentes maneiras, 
        dependendo do tipo real do objeto.   
         */
        public virtual string ColetarInformacoes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Placa: {Placa}";
        }

        // Método - Sobreescrita (Override): vai simular a ação de mover o veículo
        // Método sobrecarregado para incluir diferentes tipos de movimentos
        /*
             Ocorre quando uma classe filha (subclasse) fornece sua própria implementação de um método que já
            existe na classe pai (superclasse);
            O método na classe filha substitui o método na classe pai, fornecendo uma implementação
            específica para aquela subclasse; 
                A sobreescrita permite que as subclasses personalizem o comportamento herdado de suas
            superclasses
         */
        public void Mover()
        {
            Console.WriteLine($"{Marca} {Modelo} está se movendo.");
        }

        // Método sobreescrito (muda o parametro)
        public void Mover(int velocidade)
        {
            Console.WriteLine($"{Marca} {Modelo} está se movendo a {velocidade} km/h.");
        }
    }

    // Subclasse Carro que herda de Veiculo
    public class Carro : Veiculo
    {
        // Atributo específico da classe Carro: TipoDeCombustivel
        public string TipoDeCombustivel { get; private set; }

        // Construtor da classe Carro
        // Inicializa a classe base Veiculo com os parâmetros marca, modelo, ano e placa
        // E inicializa o atributo específico TipoDeCombustivel
        public Carro(string marca, string modelo, int ano, string placa, string tipoDeCombustivel)
            : base(marca, modelo, ano, placa)
        {
            TipoDeCombustivel = tipoDeCombustivel;
        }

        // Método sobrescrito da classe base Veiculo
        // Retorna a descrição completa do carro, incluindo o tipo de combustível
        public override string ColetarInformacoes()
        {
            return base.ColetarInformacoes() + $", Tipo de Combustível: {TipoDeCombustivel}";
        }

        // Método que simula a ação de abastecer o carro
        public void Abastecer()
        {
            Console.WriteLine($"{Marca} {Modelo} está sendo abastecido com {TipoDeCombustivel}.");
        }
    }

    // Subclasse Moto que herda de Veiculo
    public class Moto : Veiculo
    {
        // Atributo específico da classe Moto: Cilindrada
        public int Cilindrada { get; private set; }

        // Construtor da classe Moto
        // Inicializa a classe base Veiculo com os parâmetros marca, modelo, ano e placa
        // E inicializa o atributo específico Cilindrada
        public Moto(string marca, string modelo, int ano, string placa, int cilindrada)
            : base(marca, modelo, ano, placa)
        {
            Cilindrada = cilindrada;
        }

        // Método sobrescrito da classe base Veiculo
        // Retorna a descrição completa da moto, incluindo a cilindrada
        public override string ColetarInformacoes()
        {
            return base.ColetarInformacoes() + $", Cilindrada: {Cilindrada}cc";
        }

        // Método que simula a ação de empinar a moto
        public void Empinar()
        {
            Console.WriteLine($"{Marca} {Modelo} com {Cilindrada}cc está empinando!");
        }
    }

}
