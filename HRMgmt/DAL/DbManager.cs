namespace DAL;
using MySql.Data.MySqlClient;
using BOL;

public class DbManager
{
    public static string conString = @"server=localhost;port=3306;user=root;password=admin@123;database=msdotnet";

    public static List<Employee> GetAllEmps()
    {
        List<Employee> employees = new List<Employee>();
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString=conString;

        try{
            connection.Open();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=connection;
            string query="select * from emp";
            cmd.CommandText=query;
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                int empId=int.Parse(reader["empId"].ToString());
                string name=reader["name"].ToString();
                string email=reader["email"].ToString();
                string password=reader["password"].ToString();
                double salary=double.Parse(reader["salary"].ToString());
                Employee emp=new Employee(empId,name,email,password,salary); 
                employees.Add(emp);
                
            }
            }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }finally{
            connection.Close();
        }

        return employees;
    }

    public static Employee GetEmployee(int id)
    {
        
        Employee emp=null;
        MySqlConnection connection=new MySqlConnection();  // connection object
        connection.ConnectionString =conString;            // connection gettion connected to our local database

        try{
            string query="select * from emp where empId="+id;
            connection.Open();
            MySqlCommand cmd=new MySqlCommand(query,connection);
            MySqlDataReader reader=cmd.ExecuteReader();
            if(reader.Read())
            {
                int empId=int.Parse(reader["empId"].ToString());
                string name=reader["name"].ToString();
                string email=reader["email"].ToString();
                string password=reader["password"].ToString();
                double salary=double.Parse(reader["salary"].ToString());
                 emp=new Employee(empId,name,email,password,salary); 
            }


        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }


        return emp;
    }


    public static bool Insert(Employee emp)
    {
        bool status=false;
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString=conString;
        try{
            string query="insert into emp values ("+emp.empId+",'"+emp.name+"','"+emp.email+"','"+emp.password+"',"+emp.salary+")";
            connection.Open();
            MySqlCommand cmd= new MySqlCommand(query,connection);
            cmd.ExecuteNonQuery();
            status=true;    

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }

        return status;
    }

    public static bool Delete(int empid)
    {
        bool status=false;
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString =conString;
        try{
                string query="delete from emp where empId="+empid;
                connection.Open();
                MySqlCommand cmd=new MySqlCommand(query,connection);
                int rowsaffected=cmd.ExecuteNonQuery();
                status=rowsaffected>0;
        }catch(Exception e)
        {           
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return status;
    }



    

}
