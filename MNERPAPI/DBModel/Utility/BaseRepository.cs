using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DBModel.Utility
{
    public abstract class BaseRepository
    {
        private readonly IConfiguration _configuration;
        
        protected BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected IDbConnection CreateConnection()
        {
             
            return new SqlConnection(_configuration.GetConnectionString("ConnStr"));
        }
        protected SqlConnection CreateSQLConnection()
        {
            
            return new SqlConnection(ConfigurationExtensions.GetConnectionString(_configuration,"ConnStr"));
        }
    }
}
