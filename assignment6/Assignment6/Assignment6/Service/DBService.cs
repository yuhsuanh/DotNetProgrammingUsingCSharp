using Assignment6.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Service
{
    public class DBService
    {
        private static string dbConnInfo = @"Data Source=LAPTOP-S53ISC41\SQLEXPRESS;Initial Catalog=yuhsuan200443723;User ID=yuhsuanhuang;Password=huang1234";

        public static int geNumberOfStudent()
        {
            int result = 0;

            //Configure db connection
            using (SqlConnection conn = new SqlConnection(dbConnInfo))
            {
                //Sql command
                SqlCommand sql = new SqlCommand(@"SELECT COUNT(*) FROM [dbo].[Student]", conn);

                try
                {
                    //Open db connection
                    conn.Open();
                    //Execute sql command
                    string count = sql.ExecuteScalar().ToString();
                    result = int.Parse(count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return result;
        }

        public static string getStudentByID(int id)
        {
            StringBuilder sb = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(dbConnInfo))
            {

                SqlCommand sql = new SqlCommand(@"SELECT * FROM [dbo].[Student] WHERE [ID] = @ID", conn);

                //bind parameters
                sql.Parameters.Add("@ID", SqlDbType.Int);
                sql.Parameters["@ID"].Value = id;

                try
                {
                    conn.Open();

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sql;

                    DataSet dt = new DataSet();
                    sda.Fill(dt);

                    foreach (DataTable table in dt.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                object item = row[column];
                                sb.Append(item + " | ");
                            }
                            sb.Append("\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return sb.ToString();
        }

        public static string getStudents()
        {
            StringBuilder sb = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(dbConnInfo))
            {
                
                SqlCommand sql = new SqlCommand(@"SELECT * FROM [dbo].[Student]", conn);

                try
                {
                    conn.Open();

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sql;

                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    
                    foreach (DataTable table in dt.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                object item = row[column];
                                sb.Append(item + " | ");
                            }
                            sb.Append("\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return sb.ToString();
        }

        public static void insertStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(dbConnInfo))
            {
                //Sql command
                SqlCommand sql = new SqlCommand("INSERT INTO [dbo].[Student] ([first_name], [last_name], [phone]) VALUES (@firstName, @lastName, @phone)", conn);

                //bind parameters
                sql.Parameters.Add("@firstName", SqlDbType.VarChar, 50);
                sql.Parameters["@firstName"].Value = student.firstName;
                sql.Parameters.Add("@lastName", SqlDbType.VarChar, 50);
                sql.Parameters["@lastName"].Value = student.lastName;
                sql.Parameters.Add("@phone", SqlDbType.Char, 10);
                sql.Parameters["@phone"].Value = student.phone;

                try
                {
                    conn.Open();
                    Int32 rowsAffected = sql.ExecuteNonQuery();
                    Console.WriteLine("*RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void updateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(dbConnInfo))
            {
                //Sql command
                SqlCommand sql = new SqlCommand("UPDATE [dbo].[Student] SET [first_name] = @firstName, [last_name] = @lastName, [phone] = @phone WHERE [ID] = @ID", conn);

                //bind parameters
                sql.Parameters.Add("@firstName", SqlDbType.VarChar, 50);
                sql.Parameters["@firstName"].Value = student.firstName;
                sql.Parameters.Add("@lastName", SqlDbType.VarChar, 50);
                sql.Parameters["@lastName"].Value = student.lastName;
                sql.Parameters.Add("@phone", SqlDbType.Char, 10);
                sql.Parameters["@phone"].Value = student.phone;
                sql.Parameters.Add("@ID", SqlDbType.Int);
                sql.Parameters["@ID"].Value = student.id;

                try
                {
                    conn.Open();
                    Int32 rowsAffected = sql.ExecuteNonQuery();
                    Console.WriteLine("*RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    
        public static void deleteStudent(int id)
        {
            using (SqlConnection conn = new SqlConnection(dbConnInfo))
            {
                //Sql command
                SqlCommand sql = new SqlCommand("DELETE FROM [dbo].[Student] WHERE [ID] = @ID", conn);

                //bind parameters
                sql.Parameters.Add("@ID", SqlDbType.Int);
                sql.Parameters["@ID"].Value = id;

                try
                {
                    conn.Open();
                    Int32 rowsAffected = sql.ExecuteNonQuery();
                    Console.WriteLine("*RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
