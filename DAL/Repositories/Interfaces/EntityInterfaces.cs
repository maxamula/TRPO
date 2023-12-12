using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {

    }

    public interface IEngineerRepository : IRepository<Engineer>
    {

    }

    public interface IPollutantRepository : IRepository<Pollutant>
    {

    }

    public interface IRecordRepository : IRepository<Record>
    {

    }

    public interface ISensorRepository : IRepository<Sensor>
    {

    }

    public interface IValueRepository : IRepository<Value>
    {

    }
}
