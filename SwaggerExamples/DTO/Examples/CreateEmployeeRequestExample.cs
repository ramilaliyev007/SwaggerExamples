using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;

namespace SwaggerExamples.DTO.Examples
{
    public class CreateEmployeeRequestExample : IExamplesProvider<CreateEmployeeRequest>
    {
        public CreateEmployeeRequest GetExamples()
        {
            return new(Name: "Suleyman",
                       Surname: "Cakir",
                       Country: "Turkiye",
                       Age: 40);
        }
    }
}
