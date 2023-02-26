using System.Globalization;
using AngularWebDotnetApiCA.Application.Common.Interfaces;
using AngularWebDotnetApiCA.Application.TodoLists.Queries.ExportTodos;
using AngularWebDotnetApiCA.Infrastructure.Files.Maps;
using CsvHelper;

namespace AngularWebDotnetApiCA.Infrastructure.Files;

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
