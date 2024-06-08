using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana.Infrastructure
{
    public class FornecedorRepository
    {
        public bool Add(Fornecedor fornecedor)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.fornecedor(
	                        id, nome, cpfoucnpj, telefone)
	                        VALUES (@Id, @Nome, @CpfouCnpj, @Telefone);";
            var result = conn.Connection.Execute(sql: query, param: fornecedor);

            return result == 1;
        }



        public List<Fornecedor> Get()
        {
            using var conn = new DbConnection(); ;
            string querry = @"SELECT * FROM fornecedor;";
            var fornecedor = conn.Connection.Query<Fornecedor>(sql: querry);

            return fornecedor.ToList();
        }
    }
}
