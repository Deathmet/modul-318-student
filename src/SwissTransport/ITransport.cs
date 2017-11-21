namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
        Connections GetConnections(string FromStation_p, string ToStation_p, string Date_p, string Time_p, string IsArrivaltime_p);
    }
}