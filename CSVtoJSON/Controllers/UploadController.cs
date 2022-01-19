using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using ChoETL;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace CSVtoJSON.Controllers
{
    [ApiController]
    [Route("/upload")]
    public class UploadController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> PostAsync(IFormFile file)
        {
            try
            {
                string fileContent;
                using (var stream = file.OpenReadStream())
                using (var reader = new StreamReader(stream))
                {
                    fileContent = await reader.ReadToEndAsync();

                    StringBuilder stringBuilder = new StringBuilder();
                    using (var loadedCsvText = ChoCSVReader.LoadText(fileContent)
                        .WithFirstLineHeader()
                        )
                    {
                        using (var cho_writer = new ChoJSONWriter(stringBuilder))
                            cho_writer.Write(loadedCsvText);
                    }

                    return Ok(stringBuilder.ToString()); ;
                }  
            } catch (Exception e)
            {
                return StatusCode(400, e);
            }
            
        }
    }
}
