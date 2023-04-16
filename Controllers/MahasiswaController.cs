using Microsoft.AspNetCore.Mvc;
using tpmodul9_1302213018;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302213018.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
       {
           new Mahasiswa("Afny Latifa", 1302210071),
           new Mahasiswa("Herlin Priatna", 1302213018),
           new Mahasiswa("Muhammad Zulfadly", 1302210046),
           new Mahasiswa("Nurul Pratiwi", 1302213052),
           new Mahasiswa("Syahran Syahputra", 1302210021)
       };


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa updateMahasiswa)
        {
            mahasiswaList[id] = updateMahasiswa;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }
    }
}