using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana.Infrastructure
{
    public class FuncionarioRepository
    {
        public bool Add(Funcionario funcionario)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.funcionario(
	                        id, nome, cpf, funcao, salario)
	                        VALUES (@Id, @Nome, @Cpf, @Funcao, @Salario);";
            var result = conn.Connection.Execute(sql: query, param: funcionario);

            return result == 1;
        }

        

        public List<Funcionario> Get()
        {
            using var conn = new DbConnection(); ;
            string querry = @"SELECT * FROM funcionario;";
            var funcionario = conn.Connection.Query<Funcionario>(sql: querry);

            return funcionario.ToList();
        }
    }
}
