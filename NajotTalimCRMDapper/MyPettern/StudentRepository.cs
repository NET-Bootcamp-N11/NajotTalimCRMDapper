using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Formatters;
using NajotTalimCRMDapper.Entities.DTOs;
using NajotTalimCRMDapper.Models;
using Npgsql;

namespace NajotTalimCRMDapper.MyPettern
{
    public class StudentRepository : IStudentRepository
    {
        public IConfiguration _configuration;

        public StudentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateStudent(StudentDTO studentDTO)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "insert into students(full_name, age, course_id, phone, parent_phone, shot_number) VALUES (@full_name, @age, @course_id, @phone, @parent_phone, @shot_number)";

                    var parameters = new StudentDTO
                    {
                        full_name = studentDTO.full_name,
                        age = studentDTO.age,
                        course_id = studentDTO.course_id,
                        phone = studentDTO.phone,
                        parent_phone = studentDTO.parent_phone,
                        shot_number = studentDTO.shot_number
                    };


                    connection.Execute(query, parameters);

                }

                return "malumot yaratildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {

            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from students";

                var result =  connection.Query<Student>(query);

                return result;
            }

        }

        public Student GetByIdStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(int id, StudentDTO studentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
