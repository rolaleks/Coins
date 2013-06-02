using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
namespace Coins
{
    
        using System.Data;
        using System.Data.SqlClient;
    using System.Windows.Forms;

        class SQL
        {
            FbConnection fb;
            FbDataReader reader;
            FbCommand SelectSQL;
            public int error = 0;
            public SQL() {
                FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
                fb_con.Charset = "WIN1251"; //используемая кодировка
                fb_con.UserID = Program.DATALogin; //логин
                fb_con.Password = Program.DATAPass; //пароль
                if(Program.DATASource!="0")
                    fb_con.DataSource = Program.DATASource;
                if (Program.DATAPort != "0")
                    fb_con.Port = int.Parse(Program.DATAPort);
                fb_con.Database = Program.DATAserver; //путь к файлу базы данных
                fb_con.ServerType = 0; //указываем тип сервера (0 - "полноценный Firebird" (classic или super server), 1 - встроенный (embedded))


                //создаем подключение
                fb = new FbConnection(fb_con.ToString()); //передаем нашу строку подключения объекту класса FbConnection
        
            


            
            }
            public void ExecuteNonQuery(String query)
            {
                error = 0;
                if (fb.State == ConnectionState.Closed)
                    fb.Open();


                FbDatabaseInfo fb_inf = new FbDatabaseInfo(fb); //информация о БД


                //пока у объекта БД не был вызван метод Open() - никакой информации о БД не получить, будет только ошибка
               // MessageBox.Show("Info: " + fb_inf.ServerClass + "; " + fb_inf.ServerVersion); //выводим тип и версию используемого сервера Firebird

                FbCommand InsertSQL = new FbCommand(query, fb);//"INSERT INTO COINS (NAME,NUMBER,CAT,IMAGE_JPG,IMAGE_CDR) VALUES('" + textBox1.Text + "')", fb);


                if (fb.State == ConnectionState.Closed) //если соединение закрыто - откроем его; Перечисление ConnectionState содержит состояния соединения (подключено/отключено)
                    fb.Open();


                FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)
                InsertSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта InsertSQL
                try
                {
                    int res = InsertSQL.ExecuteNonQuery(); //для запросов, не возвращающих набор данных (insert, update, delete) надо вызывать этот метод
                    //MessageBox.Show("SUCCESS: " + res.ToString());
                    fbt.Commit(); //если вставка прошла успешно - комитим транзакцию
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); error = 1;
                }


                InsertSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать объекты этого типа, если они больше не нужны
                fb.Close();
            }
            public FbDataReader StartQuery(String query)
            {
                error = 0;
                try
                {
                    //так проверять состояние соединения (активно или не активно)
                    if (fb.State == ConnectionState.Closed)
                        fb.Open();


                    FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)


                    SelectSQL = new FbCommand(query, fb);//"SELECT * FROM CAT", fb); //задаем запрос на выборку


                    SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
                    reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()



                    return reader;
                }
                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show(ex.Message);
                }
                return reader;
        
            
            }
            public void EndQuery() {
                error = 0;
                try
                {
                    reader.Close();
                    fb.Close(); //закрываем соединение, т.к. оно нам больше не нужно

                    SelectSQL.Dispose(); //в документации написано, что ОЧЕНЬ рекомендуется убивать 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); error = 1;
                }
            
            }
            
        }
    
}
