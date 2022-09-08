using System;
using System.Collections.Generic;
using System.Data;

namespace Core
{
    class CategoryRepository :BaseRepository<Category>
    {
        IDbConnection connection;
        public CategoryRepository(IDbConnection connection) :base(connection)
        {
           
        }
        // Category Fetch(IDataReader reader)
        //{
        //    return new Category
        //    {
        //        ID = (short)reader["CategoryID"],
        //        Name = (string)reader["CategoryName"],

        //    };
        //}
        public int Add(Category obj)
        {
            DynamicParameter parameter = new DynamicParameter();
            parameter.Add("@Name", obj.Name);
            return Save("Insert into category(categoryName) values (@name)", parameter);
        }
        public Category GetCategoriesByID(short id)
        {
            DynamicParameter parameter = new DynamicParameter();
            parameter.Add("@ID", id);
            return FetchOne("select*from Category where CategoryID = @ID", parameter);
            //using (IDbCommand command = connection.CreateCommand())
            //{
            //    command.CommandText = "select* form Category where category= @id";
            //    IDbDataParameter parameter = command.CreateParameter();
            //    parameter.Value = id;
            //    parameter.ParameterName = "@id";
            //    command.Parameters.Add(parameter);
            //    using (IDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            return Fetch(reader);
            //        }
            //        return null;
            //    }
            //}
        }
        public List<Category> GetCategories()
        {
            //using (IDbCommand command = connection.CreateCommand())
            //{
            //    command.CommandText = "select* form Category";
            //    using (IDataReader reader = command.ExecuteReader())
            //    {
            //        List<Category> list = new List<Category>();
            //        while (reader.Read())
            //        {
            //            list.Add(Fetch(reader));
            //        }
            //        return list;
            //    }
            //}
            return FetchAll("select * from Category", new CategoryMapper());
        }

        protected override Category Fetch(IDataReader reader)
        {
            return new Category
            {
                ID = (short)reader["CategoryID"],
                Name = (string)reader["CategoryName"],
            };
        }
    }
}
