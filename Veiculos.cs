public class Veiculos
{
    public int _idVeiculo;
    private string _niv;
    public string _placa;
    public string _motor;
    public string _renavam;
    public string _ano;
    public Modelos _modelo;
    public string _situacao;
    public string _cor;
    public Proprietarios _proprietario;

    public void SetNiv(string niv)
    {
        try
        {
            if (niv.Length == 17)
            {
                _niv = niv;
            }
            else
            {
                throw new Exception("NIV Incorreto");
            }
        }
        catch (Exception ex) 
        { 
            throw new Exception(ex.Message); 
        }

    }
    public string GetNiv()
    {
        return _niv;
    }

}