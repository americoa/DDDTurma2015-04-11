using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.ControleFinanceiro.Domain.Contracts.Repositories;
using LGroup.ControleFinanceiro.Domain.Entities;
using LGroup.ControleFinanceiro.Domain.ValueObjects;

namespace LGroup.ControleFinanceiro.Application.Services
{
    public sealed class RecebimentoApplicationService
        : Core.BaseApplication
        , Contracts.IRecebimentoApplicationService
    {
        //Váriáveis internas para para receber
        // a injeção de dependência via construtor
        private readonly IRecebimentoRepository _recebimentoRepository;
        private readonly ICreditoRepository _creditoRepository;

        //Construtor tendo injetado as interfaces necessárias
        // para a utilização deste ApplicationService
        public RecebimentoApplicationService(
            IRecebimentoRepository recebimentoRepository,
            ICreditoRepository creditoRepository)
        {
            //Repasse da injeção para as variáveis internas
            _recebimentoRepository = recebimentoRepository;
            _creditoRepository = creditoRepository;
        }

        public IEnumerable<Dtos.RecebimentoDto> Consultar()
        {
            var recebimentos =
                _recebimentoRepository.GetAll();

            return
                recebimentos.ToList().ConvertAll(
                    recebimento => new Dtos.RecebimentoDto
                    {
                        Codigo = recebimento.Codigo,
                        CodigoCredito = recebimento.CodigoCredito,
                        CodigoRecebimentoTipo = (int)recebimento.Tipo,
                        DataEntrada = recebimento.DataEntrada,
                        Nome = recebimento.Nome
                    }
                );
        }

        public void Adicionar(string nome, int codigoRecebimentoTipo, int codigoCredito)
        {
            //Criou a entidade de recebimento
            var recebimento =
                new Recebimento(nome, (Tipo)codigoRecebimentoTipo);

            //Buscamos o crédito daquele recebimento
            var credito =
                _creditoRepository.GetByCodigo(codigoCredito);

            //Definimos o crédito na entidade
            recebimento.AlterarCredito(credito);

            //Iniciamos o nosso Unit Of Work através da nossa classe
            // BaseApplication
            Begin();

            //Salvamos no banco
            _recebimentoRepository.Add(recebimento);

            //Efetuamos (comitamos) as alterações pelo nosso
            // Unit of Work através da nossa classe BaseApplication
            SaveChanges();
        }
    }
}
