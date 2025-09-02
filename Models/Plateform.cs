using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RelationsNaN.Models
{
    public class Plateform
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ValidateNever]
        public List<Game> Games { get; set; }
    }
}
