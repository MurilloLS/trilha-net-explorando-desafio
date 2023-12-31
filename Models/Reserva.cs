namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado! (TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido)
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado! (TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido)
                throw new InvalidOperationException("Capacidade máxima de hóspedes excedida.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado! (TODO: Retorna a quantidade de hóspedes (propriedade Hospedes))
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado! (TODO: Retorna o valor da diária)
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Implementado! (Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%)
            if (DiasReservados >= 10)
            {
                valor -= valor*10/100;
            }

            return valor;
        }
    }
}