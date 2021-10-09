using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace todomile.Functions.Entities
{
    internal class TodoEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

    }
}
