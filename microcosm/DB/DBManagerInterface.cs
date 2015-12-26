using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using microcosm.DB;

namespace microcosm
{
    interface DBManagerInterface
    {
        List<UserDir> getObject();

    }
}
