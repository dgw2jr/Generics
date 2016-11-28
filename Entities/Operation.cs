using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Operation : IIdentifier<int>
    {
        [Key, Column("OperationId"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int PrimaryDecisionMakerId { get; set; }
    }
}
