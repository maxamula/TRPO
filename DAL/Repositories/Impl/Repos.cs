using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class AppointmentRepository
        : BaseRepository<Appointment>, IAppointmentRepository
    {
        internal AppointmentRepository(EF.DatabaseContext context)
        : base(context)
        {
        }
    }

    public class EngineerRepository : BaseRepository<Engineer>, IEngineerRepository
    {
        internal EngineerRepository(EF.DatabaseContext context) : base(context)
        {
        }
    }

    public class PollutantRepository : BaseRepository<Pollutant>, IPollutantRepository
    {
        internal PollutantRepository(EF.DatabaseContext context) : base(context)
        {
        }
    }

    public class RecordRepository : BaseRepository<Record>, IRecordRepository
    {
        internal RecordRepository(EF.DatabaseContext context) : base(context)
        {
        }
    }

    public class SensorRepository : BaseRepository<Sensor>, ISensorRepository
    {
        internal SensorRepository(EF.DatabaseContext context) : base(context)
        {
        }
    }

    public class ValueRepository : BaseRepository<Value>, IValueRepository
    {
        internal ValueRepository(EF.DatabaseContext context) : base(context)
        {
        }
    }

}
