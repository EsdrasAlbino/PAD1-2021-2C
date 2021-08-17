namespace segundo_c.abstrato
{
    public abstract class Empregado
    {
        public string nome;
        public string sobrenome;
        public string cpf;

        public Empregado(string nome, string sobrenome, string cpf){
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
        }

        public abstract double salario();
    }
}