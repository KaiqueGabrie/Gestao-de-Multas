using GestaodeMultas271124.Entidades;

Veiculos v = new Veiculos();

Console.WriteLine("Informe o id do veículo: ");
v._idVeiculo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o número do Chassi(NIV) do veículo: ");
string niv = Console.ReadLine();
v.SetNIV(niv);

Console.WriteLine("Informe a placa do veículo: ");
v._placa = Console.ReadLine();

Console.WriteLine("Infome o número do motor do veículo: ");
v._numMotor = Console.ReadLine();

Console.WriteLine("Informe o Renavam do veículo: ");
v._Renavam = Console.ReadLine();

Console.WriteLine("Informe o ano/modelo do veículo: ");
v._anoModelo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a situação do veículo: ");
v._situacao = Console.ReadLine();

Console.WriteLine("Informe a cor do veículo: ");
v._cor = Console.ReadLine();
