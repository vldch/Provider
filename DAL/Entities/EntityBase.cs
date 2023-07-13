using System.ComponentModel.DataAnnotations;

namespace Provider.DAL.Entities
{
    public class EntityBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public long Id { get; set; }
    }

}
