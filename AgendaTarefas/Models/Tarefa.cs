using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTarefas.Models
{
    public class Tarefa

    {
        public int Tarefaid { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Time)]
        public string Horário { get; set; }
    }
}
