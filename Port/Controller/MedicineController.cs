using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Port.Model;
using Port.Repository;

namespace Port.Controller
{
    [Route("v1/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineRepository _medicineRepository;

        public MedicineController(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Medicine medicines)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var created = _medicineRepository.Create(medicines);
            return Ok(created);
        }

        [HttpGet("{skip}/{take}")]
        public IActionResult Find([FromRoute] int skip = 0, int take = 25)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var findAll = _medicineRepository.Find(skip, take);
            return Ok(findAll);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var findId = _medicineRepository.FindById(id);
            return Ok(findId);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Medicine medicine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var updated = _medicineRepository.Update(medicine);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _medicineRepository.Delete(id);
            return NoContent();
        }
    }
}
