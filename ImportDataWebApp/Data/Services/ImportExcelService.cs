using ImportDataWebApp.Data.Models;
using OfficeOpenXml;

namespace ImportDataWebApp.Data.Services
{
    public class ImportExcelService
    {
        readonly ExcelImportDbContext _dbContext = new();

        public ImportExcelService(ExcelImportDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ProcessExcelFile(Stream stream)
        {
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.First();
                var rowCount = worksheet.Dimension.Rows;

                var crimes2023List = new List<Crimes2023>();

                for (int row = 2; row <= rowCount; row++)
                {
                    int val = 0;

                    var crimesData = new Crimes2023();

                    if (int.TryParse(worksheet.Cells[row, 1].Text, out int parsedId))
                    {
                        crimesData.Id = parsedId;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    crimesData.CaseNumber = worksheet.Cells[row, 2].Text;
                    crimesData.Date = DateTime.Parse(worksheet.Cells[row, 3].Text);
                    crimesData.Block = worksheet.Cells[row, 4].Text;
                    crimesData.Iucr = worksheet.Cells[row, 5].Text;
                    crimesData.PrimaryType = worksheet.Cells[row, 6].Text;
                    crimesData.Description = worksheet.Cells[row, 7].Text;
                    crimesData.LocationDescription = worksheet.Cells[row, 8].Text;
                    
                    if (int.TryParse(worksheet.Cells[row, 9].Text, out int parsedArrest))
                    {
                        crimesData.Arrest = parsedArrest;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 10].Text, out int parsedDomestic))
                    {
                        crimesData.Domestic = parsedDomestic;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 11].Text, out int parsedBeat))
                    {
                        crimesData.Beat = parsedBeat;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 12].Text, out int parsedDistrict))
                    {
                        crimesData.District = parsedDistrict;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.

                    }

                    if (int.TryParse(worksheet.Cells[row, 13].Text, out int parsedWard))
                    {
                        crimesData.Ward = parsedWard;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 14].Text, out int parsedCommunityArea))
                    {
                        crimesData.CommunityArea = parsedCommunityArea;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 15].Text, out int parsedFbicode))
                    {
                        crimesData.Fbicode = parsedFbicode;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 16].Text, out int parsedXcoordinate))
                    {
                        crimesData.Xcoordinate = parsedXcoordinate;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 17].Text, out int parsedYcoordinate))
                    {
                        crimesData.Ycoordinate = parsedYcoordinate;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 18].Text, out int parsedYear))
                    {
                        crimesData.Year = parsedYear;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    crimesData.UpdatedOn = DateTime.Parse(worksheet.Cells[row, 19].Text);

                    if (int.TryParse(worksheet.Cells[row, 20].Text, out int parsedLatitude))
                    {
                        crimesData.Latitude = parsedLatitude;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }
                    if (int.TryParse(worksheet.Cells[row, 21].Text, out int parsedLongitude))
                    {
                        crimesData.Longitude = parsedLongitude;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }

                    if (int.TryParse(worksheet.Cells[row, 22].Text, out int parsedLocation))
                    {
                        crimesData.Location = parsedLocation;
                    }
                    else
                    {
                        // Handle the case where the cell's content does not represent a valid integer for Id.
                        // You can assign a default value to Id or take other appropriate actions.
                    }
                   
                    crimes2023List.Add(crimesData);
                }

                // Save crimesDataList to the database
                foreach (var item in crimes2023List)
                {
                    _dbContext.Crimes2023s.Add(item);
                }
                _dbContext.SaveChanges();

                return true; // Indicate successful processing
            }
        }
    }
}
