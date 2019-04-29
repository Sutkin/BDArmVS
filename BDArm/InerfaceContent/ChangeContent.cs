﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BDArm.InerfaceContent
{
    class InsertContentMaker : InterfaceContentStrategy
    {
        public void InsertContent(string str)
        {
            var sqlCommand = new NpgsqlCommand();
            using (NpgsqlConnection conn = new NpgsqlConnection(MainForm.ConnString))
            {

                //Проверка на уникльность наименования
                sqlCommand = new NpgsqlCommand
                {
                    Connection = conn,
                    CommandText = @"select count(*) from maker where name = @currentName"
                };
                sqlCommand.Parameters.AddWithValue("@currentName", str);

                conn.Open();
                if ((long)sqlCommand.ExecuteScalar() != 0)
                {
                    MessageBox.Show("Такой производитель уже есть.");
                }
                else
                {
                    //Меняем имя
                    sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = @"insert into maker values ((select max(id)+1 from maker), @newName)"
                    };
                    sqlCommand.Parameters.AddWithValue("@newName", str);
                }
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
                conn.Close();
            }
        }
    }

    class InsertPromo : InterfaceContentStrategy
    {
        public void InsertContent(string str)
        {
            var sqlCommand = new NpgsqlCommand();
            using (NpgsqlConnection conn = new NpgsqlConnection(MainForm.ConnString))
            {

                //Проверка на уникльность наименования
                sqlCommand = new NpgsqlCommand
                {
                    Connection = conn,
                    CommandText = @"select count(*) from promo where code = @currentName"
                };
                sqlCommand.Parameters.AddWithValue("@currentName", str);

                conn.Open();
                if ((long)sqlCommand.ExecuteScalar() != 0)
                {
                    MessageBox.Show("Такой промокод уже есть.");
                }
                else
                {
                    //Меняем имя
                    sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = @"insert into promo values ((select max(id)+1 from promo), @newName)"
                    };
                    sqlCommand.Parameters.AddWithValue("@newName", str);
                }
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
                conn.Close();
            }
        }
    }

    class UpdateContentMaker : InterfaceUpdateContent
    {
        public void UpdateMakerContent(string strOld,string strNew)
        {
            var sqlCommand = new NpgsqlCommand();
            using (NpgsqlConnection conn = new NpgsqlConnection(MainForm.ConnString))
            {

                //Проверка на уникльность наименования
                sqlCommand = new NpgsqlCommand
                {
                    Connection = conn,
                    CommandText = @"select count(*) from maker where name = @currentName"
                };
                sqlCommand.Parameters.AddWithValue("@currentName", strNew);

                conn.Open();
                if ((long)sqlCommand.ExecuteScalar() != 0)
                {
                    MessageBox.Show("Такой производитель уже есть.");
                }
                else
                {
                    //Меняем имя
                    sqlCommand = new NpgsqlCommand
                    {
                        Connection = conn,
                        CommandText = @"update maker set name = @newName where name = @currentName"
                    };
                    sqlCommand.Parameters.AddWithValue("@currentName", strOld);
                    sqlCommand.Parameters.AddWithValue("@newName", strNew);
                }
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
            //throw new NotImplementedException();
        }
    }
}
