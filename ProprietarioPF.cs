public class ProprietarioPF:Proprietarios // PropritarioPF está herdando de seu pai (Proprietarios)
{
    public int _idPropPF;
    private string _cpf;
    public string _rg;
    public string _dtNascimento;
    public string _sexo;

    public void SetCpf(string cpf)
    {
        try
        {
            if (cpf.Length != 7)
            {
                throw new Exception("|ERRO| O CPF deverá conter 7 caracteres!");
            }
            else
            {
                _cpf = cpf;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}