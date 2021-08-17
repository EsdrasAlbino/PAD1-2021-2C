namespace terceirobimestre.diagrama
{
  public class Usuario
  {
    private Colaborador c;
    private string login;
    private string senha;
    private string permissao;

    public string Login { get => login; set => login = value; }
    public string Senha { get => senha; set => senha = value; }
    public string Permissao { get => permissao; set => permissao = value; }
    public Colaborador C { get => c; set => c = value; }

    private void editarPerfil(){}
    private void alterarSenha(){}
    private void criarUsuario(){}
    private void apagarUsuario(){}
  }
}