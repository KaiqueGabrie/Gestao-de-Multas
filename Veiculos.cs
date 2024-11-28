using System.Threading.Channels;

public class Veiculos {
    public int _idVeiculo;
    private string _NIV;
    public string _placa;
    public string _numMotor;
    public string _Renavam;
    public int _anoModelo;
    public string _situacao;
    public string _cor;
    public Cidades cidade;
    public Proprietarios proprietario;
    public Modelos modelo;

    public void SetNIV(string NIV)
    {
        try
        {
            if (NIV.Length != 17)
            {
                throw new Exception("|ERRO| o número do Chassi(NIV) deve ter 17 caracteres!");
            }
            else
            {
                _NIV = NIV;
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);

        }
        
    }
}