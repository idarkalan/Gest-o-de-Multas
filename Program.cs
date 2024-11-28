try
{
	Veiculos v1 = new Veiculos();
    Console.WriteLine("Informe o numero do NIV: ");
	string niv = Console.ReadLine();
	v1.SetNiv(niv);
}
catch (Exception ex)
{

	Console.WriteLine(ex.Message);
}