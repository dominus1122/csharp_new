using BlazorCrudCDx.Context;
using Microsoft.EntityFrameworkCore;


namespace BlazorCrudCDx.Model
{
    public class EmployeeService
    {
        private readonly ApplicationDBContext _dbContext;
        public EmployeeService(ApplicationDBContext dBContext)
        {

            _dbContext = dBContext;

        }

        //Get All Employee Method
        public async Task<List<Employee>> GetAllEmployee()
        {
            return await _dbContext.Employee.ToListAsync();
         
        }


    }
}
