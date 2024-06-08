using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimFazendaUrbana.Infrastructure
{
    public class SafraRepository
    {
        public bool Add(Safra safra)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.safra(
	                        id, produto, dtPlantio, qtdPlantio, dtColheita, qtdColhida)
	                        VALUES (@Id, @Produto, @DtPlantio, @QtdPlantio, @DtColheita, @QtdColhida);";
            var result = conn.Connection.Execute(sql: query, param: safra);

            return result == 1;
        }



        public List<Safra> Get()
        {
            using var conn = new DbConnection(); ;
            string querry = @"SELECT * FROM produto;";
            var safra = conn.Connection.Query<Safra>(sql: querry);

            return safra.ToList();
        }
    }
}

                            