using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTravelHelperGUI
{
    class TimeTabelValues
    {
        /// <summary>
        /// Setzt Abfahrtsstation/ Gibt Abfahrtstation zurück
        /// </summary>
        public string FromStation_g { get; set; }

        /// <summary>
        /// Setzt Abfahrtszeit / Gibt Abfahrtszeit zurück
        /// </summary>
        public String DepartureTime_g { get; set; }

        /// <summary>
        /// Setzt Zielstation / Gibt Zielstation zurück
        /// </summary>
        public string ToStation_g { get; set; }

        /// <summary>
        /// Setzt Ankunftszeit / Gibt Ankunftszeit zurück
        /// </summary>
        public String ArrivalTime_g { get; set; }

        /// <summary>
        /// Setzt Fahrtdaue / Gibt Fahrtdauer zurück
        /// </summary>
        public string Durration_g { get; set; }

        /// <summary>
        /// Setzt Gleis / Gibt Gleis zurück
        /// </summary>
        public string Line_g { get; set; }
    }
}
