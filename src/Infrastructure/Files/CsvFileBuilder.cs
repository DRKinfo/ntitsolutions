using System.Globalization;
using ntitsolutions.Application.Common.Interfaces;
using ntitsolutions.Application.TodoLists.Queries.ExportTodos;
using ntitsolutions.Infrastructure.Files.Maps;
using CsvHelper;

namespace ntitsolutions.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
