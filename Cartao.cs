namespace Lista_de_Objetos_Cartao
{
    public class Cartao
    {
        //atributos
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public int Vencimento { get; set; }
        public int Cvv { get; set; }

        //metodos construtores
        public Cartao(){

        }

        public Cartao(string _titular, int _numero, string _bandeira, int _vencimento, int _cvv){
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
            this.Cvv = _cvv;
        }
        
    }
}